using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

namespace Bewerbungsprojekt
{
    public partial class MainForm : Form
    {
        #region VARIABLES
        // Move window variables
        private bool mouseDown;
        private Point lastLocation;

        // Encryption method variable
        private EncryptionMethod encryptionMethod;

        private readonly static byte[] salt = { 73, 61, 63, 74 };
        #endregion

        #region GENERAL METHODS
        public MainForm()
        {
            InitializeComponent();

            Icon = Properties.Resources.Icon1;

            // Initialize values
            mouseDown = false;
            EncryptionMethodComboBox.SelectedIndex = 0;
            SetEncryptionMethod(0);

        }

        /// <summary>
        /// Minimizes window.
        /// </summary>
        private void MinimizeWindow()
        {
            WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Closes the application.
        /// </summary>
        private void CloseApplication()
        {
            Application.Exit();
        }
        #endregion

        #region CRYPTOGRAPHY METHODS
        /// <summary>
        /// Changes the encrpytion method. AES-128 or AES-256.
        /// </summary>
        /// <param name="index">0 = AES-128 | 1 = AES-256</param>
        private void SetEncryptionMethod(int index)
        {
            if (index == 0)
            {
                encryptionMethod = EncryptionMethod.AES128;
                KeyChatLengthLabel.Text = "(24 characters)";
            }
            else if (index == 1)
            {
                encryptionMethod = EncryptionMethod.AES256;
                KeyChatLengthLabel.Text = "(44 characters)";
            }
        }
        /// <summary>
        /// Generates the secret key based on a given password.
        /// </summary>
        /// <param name="password">Password.</param>
        /// <returns>Secret key as a byte array.</returns>
        private byte[] GenerateSecretKeyFromPassword(string password)
        {
            byte[] key;

            if (encryptionMethod.Equals(EncryptionMethod.AES128))
            {
                key = KeyDerivation.Pbkdf2(password, salt, KeyDerivationPrf.HMACSHA256, 2, 16);
                SecretKeyTextBox.Text = ConvertBytesToString(key);
            }
            else
            {
                key = KeyDerivation.Pbkdf2(password, salt, KeyDerivationPrf.HMACSHA256, 2, 32);
                SecretKeyTextBox.Text = ConvertBytesToString(key);
            }

            return key;
        }
        /// <summary>
        /// Generates the IV based on the given password.
        /// </summary>
        /// <param name="password">Password.</param>
        /// <returns>IV as a byte array.</returns>
        private byte[] GenerateIVFromPassword(string password)
        {
            byte[] IV;

            IV = KeyDerivation.Pbkdf2(password, salt, KeyDerivationPrf.HMACSHA256, 3, 16);
            IVTextBox.Text = ConvertBytesToString(IV);

            return IV;
        }

        /// <summary>
        /// Calls the encrypt or decrypt function and displayes the results.
        /// It is called when the encrypt/decrypt button is clicked.
        /// </summary>
        private void EncryptDecrypt()
        {
            // Null check
            if (PasswordTextBox.Text == null || PasswordTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Password field cannot be empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (InputTextBox.Text == null || InputTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Input field cannot be empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            byte[] key = GenerateSecretKeyFromPassword(PasswordTextBox.Text);
            byte[] IV = GenerateIVFromPassword(PasswordTextBox.Text);

            // Encrypt
            if (!EncryptDecryptToggle.Checked)
            {
                // Encrypt text
                byte[] encryptedText = Encrypt(InputTextBox.Text, key, IV);

                // Display text
                OutputTextBox.Text = ConvertBytesToString(encryptedText);
            }

            // Decrypt
            else if (EncryptDecryptToggle.Checked)
            {
                byte[] encryptedText;

                // Convert encrypted text, secret key and IV to bytes array
                try
                {
                    encryptedText = ConvertStringToBytes(InputTextBox.Text);
                }
                catch
                {
                    SecretKeyTextBox.Text = "";
                    IVTextBox.Text = "";

                    MessageBox.Show("The given input is not valid and could not be converted! Check the input text again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                // Display decrypted tex
                OutputTextBox.Text = Decrypt(encryptedText, key, IV);
            }
        }

        /// <summary>
        /// Encrypts a normal string using the AES Algorithm.
        /// </summary>
        /// <param name="textToEncrypt">String/Text to encrypt.</param>
        /// <param name="key">Secret Key to encrypt/decrypt the string.</param>
        /// <param name="IV">Initialization vector.</param>
        /// <returns>The encrypted text as a bytes array.</returns>
        private byte[] Encrypt(string textToEncrypt, byte[] key, byte[] IV)
        {
            // Encrypted text variable (in bytes)
            byte[] encryptedText;

            // Create an Aes object
            using (Aes aes = Aes.Create())
            {
                // Set key size based on encryption method
                if (encryptionMethod.Equals(EncryptionMethod.AES128))
                {
                    aes.KeySize = 128;
                }
                else
                {
                    aes.KeySize = 256;
                }

                // Set padding mode and key and IV
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = key;
                aes.IV = IV;

                // Create an encryptor to perform the stream transform
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                // Create the streams used for encryption
                using (MemoryStream memoryStream = new MemoryStream())
                {

                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {

                        using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                        {
                            // Write all data to the stream
                            streamWriter.Write(textToEncrypt);
                        }

                        // Write the stream content to a byte array
                        encryptedText = memoryStream.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream
            return encryptedText;
        }
        /// <summary>
        /// Decrypts a normal string using the AES Algorithm.
        /// </summary>
        /// <param name="textToDecrypt">Byte array to decrypt.</param>
        /// <param name="key">Secret Key to encrypt/decrypt the string.</param>
        /// <param name="IV">Initialization vector.</param>
        /// <returns>The decrypted text as a string.</returns>
        private string Decrypt(byte[] textToDecrypt, byte[] key, byte[] IV)
        {
            // Decrypted text variable
            string decryptedText;

            // Create an Aes object
            using (Aes aes = Aes.Create())
            {
                // Set key size based on the enctyption method
                if (encryptionMethod.Equals(EncryptionMethod.AES128))
                {
                    aes.KeySize = 128;
                }
                else
                {
                    aes.KeySize = 256;
                }

                // Set padding mode, key and IV
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = key;
                aes.IV = IV;

                // Create a decryptor to perform the stream transform
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                // Create the streams used for decryption
                using (MemoryStream memoryStream = new MemoryStream(textToDecrypt))
                {
                    // Encrypt data using the given encryptor
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        // Create StreamReader and write data to a stream
                        using (StreamReader streamReader = new StreamReader(cryptoStream))
                        {
                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string
                            try
                            {
                                decryptedText = streamReader.ReadToEnd();
                            }
                            catch
                            {
                                // Empty the secret key field and the IV field
                                SecretKeyTextBox.Text = "";
                                IVTextBox.Text = "";

                                MessageBox.Show("Decryption failed! Be sure that the encryption method and the password are the same used to encrypt the text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                return "";
                            }
                        }
                    }
                }
            }

            // Return the decrypted string 
            return decryptedText;
        }
        #endregion

        #region UTILS
        private byte[] ConvertStringToBytes(string text)
        {
            return Convert.FromBase64String(text);
        }

        private string ConvertBytesToString(byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }
        #endregion

        #region EVENTS METHODS
        /// <summary>
        /// Called when mouse starts clicking the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Update bool.
            mouseDown = true;

            //Get mouse position when form is clicked by the mouse.
            lastLocation = e.Location;
        }
        /// <summary>
        /// Called when mouse stops clicking the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        /// <summary>
        /// Called when mouse moves while form is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                // Updates form location when mouse moves while the form is clicked.
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }


        /// <summary>
        /// Exits application when close button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseApplication();
        }
        /// <summary>
        /// Minimizes application when minimize button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            MinimizeWindow();
        }

        /// <summary>
        /// Called when encrypt/decrypt toggle is checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EncryptDecryptToggle_CheckedChanged(object sender, EventArgs e)
        {
            // Encrypt
            if (!EncryptDecryptToggle.Checked)
            {
                GoButton.Text = "Encrypt";
            }

            // Decrypt
            else if (EncryptDecryptToggle.Checked)
            {
                GoButton.Text = "Decrypt";
            }
        }
        private void EncryptionMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEncryptionMethod(EncryptionMethodComboBox.SelectedIndex);
        }

        /// <summary>
        /// Called when the encrypt/decrypt button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoButton_Click(object sender, EventArgs e)
        {
            EncryptDecrypt();
        }
        #endregion
    }

    public enum EncryptionMethod
    {
        AES128,
        AES256
    }
}

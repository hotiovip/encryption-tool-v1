namespace Bewerbungsprojekt
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Title = new MetroFramework.Controls.MetroLabel();
            CloseButton = new Button();
            MinimizeButton = new Button();
            InputTextBox = new TextBox();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            OutputTextBox = new TextBox();
            metroLabel4 = new MetroFramework.Controls.MetroLabel();
            GoButton = new MetroFramework.Controls.MetroButton();
            metroLabel5 = new MetroFramework.Controls.MetroLabel();
            SecretKeyTextBox = new TextBox();
            IVTextBox = new TextBox();
            KeyChatLengthLabel = new MetroFramework.Controls.MetroLabel();
            metroLabel3 = new MetroFramework.Controls.MetroLabel();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            EncryptDecryptToggle = new MetroFramework.Controls.MetroToggle();
            EncryptionMethodComboBox = new MetroFramework.Controls.MetroComboBox();
            metroLabel6 = new MetroFramework.Controls.MetroLabel();
            metroLabel7 = new MetroFramework.Controls.MetroLabel();
            label1 = new Label();
            PasswordTextBox = new TextBox();
            metroLabel8 = new MetroFramework.Controls.MetroLabel();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.SlateGray;
            Title.CustomBackground = true;
            Title.CustomForeColor = true;
            Title.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Title.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            Title.ForeColor = Color.Black;
            Title.ImageAlign = ContentAlignment.MiddleLeft;
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(217, 19);
            Title.TabIndex = 0;
            Title.Text = "ENCRYPTION/DECRYPTION TOOL";
            Title.TextAlign = ContentAlignment.MiddleLeft;
            Title.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.BackColor = Color.Red;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.Location = new Point(994, 5);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(31, 23);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // MinimizeButton
            // 
            MinimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimizeButton.BackColor = Color.FromArgb(224, 224, 224);
            MinimizeButton.Cursor = Cursors.Hand;
            MinimizeButton.FlatAppearance.BorderSize = 0;
            MinimizeButton.FlatStyle = FlatStyle.Flat;
            MinimizeButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MinimizeButton.ImageAlign = ContentAlignment.TopCenter;
            MinimizeButton.Location = new Point(957, 5);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(31, 23);
            MinimizeButton.TabIndex = 2;
            MinimizeButton.Text = "-";
            MinimizeButton.TextAlign = ContentAlignment.TopCenter;
            MinimizeButton.UseVisualStyleBackColor = false;
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // InputTextBox
            // 
            InputTextBox.Anchor = AnchorStyles.Bottom;
            InputTextBox.Location = new Point(12, 346);
            InputTextBox.Multiline = true;
            InputTextBox.Name = "InputTextBox";
            InputTextBox.PlaceholderText = "Write something here...";
            InputTextBox.Size = new Size(375, 200);
            InputTextBox.TabIndex = 4;
            // 
            // metroLabel1
            // 
            metroLabel1.Anchor = AnchorStyles.Bottom;
            metroLabel1.AutoSize = true;
            metroLabel1.BackColor = Color.SlateGray;
            metroLabel1.CustomBackground = true;
            metroLabel1.CustomForeColor = true;
            metroLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel1.ForeColor = Color.Black;
            metroLabel1.ImageAlign = ContentAlignment.MiddleLeft;
            metroLabel1.Location = new Point(650, 324);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(54, 19);
            metroLabel1.TabIndex = 5;
            metroLabel1.Text = "Output";
            metroLabel1.TextAlign = ContentAlignment.MiddleLeft;
            metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // OutputTextBox
            // 
            OutputTextBox.Anchor = AnchorStyles.Bottom;
            OutputTextBox.BackColor = SystemColors.Window;
            OutputTextBox.Location = new Point(650, 346);
            OutputTextBox.Multiline = true;
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.PlaceholderText = "Here will be displayed the output.";
            OutputTextBox.Size = new Size(375, 200);
            OutputTextBox.TabIndex = 6;
            // 
            // metroLabel4
            // 
            metroLabel4.Anchor = AnchorStyles.Bottom;
            metroLabel4.AutoSize = true;
            metroLabel4.BackColor = Color.SlateGray;
            metroLabel4.CustomBackground = true;
            metroLabel4.CustomForeColor = true;
            metroLabel4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel4.ForeColor = Color.Black;
            metroLabel4.ImageAlign = ContentAlignment.MiddleLeft;
            metroLabel4.Location = new Point(12, 324);
            metroLabel4.Name = "metroLabel4";
            metroLabel4.Size = new Size(42, 19);
            metroLabel4.TabIndex = 10;
            metroLabel4.Text = "Input";
            metroLabel4.TextAlign = ContentAlignment.MiddleLeft;
            metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // GoButton
            // 
            GoButton.Anchor = AnchorStyles.Bottom;
            GoButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            GoButton.Location = new Point(469, 553);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(91, 36);
            GoButton.TabIndex = 11;
            GoButton.Text = "Encrypt";
            GoButton.Click += GoButton_Click;
            // 
            // metroLabel5
            // 
            metroLabel5.Anchor = AnchorStyles.Bottom;
            metroLabel5.AutoSize = true;
            metroLabel5.BackColor = Color.SlateGray;
            metroLabel5.CustomBackground = true;
            metroLabel5.CustomForeColor = true;
            metroLabel5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel5.ForeColor = Color.Black;
            metroLabel5.ImageAlign = ContentAlignment.MiddleLeft;
            metroLabel5.Location = new Point(650, 76);
            metroLabel5.Name = "metroLabel5";
            metroLabel5.Size = new Size(72, 19);
            metroLabel5.TabIndex = 12;
            metroLabel5.Text = "Secret Key";
            metroLabel5.TextAlign = ContentAlignment.MiddleLeft;
            metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // SecretKeyTextBox
            // 
            SecretKeyTextBox.Anchor = AnchorStyles.Bottom;
            SecretKeyTextBox.Location = new Point(650, 98);
            SecretKeyTextBox.Multiline = true;
            SecretKeyTextBox.Name = "SecretKeyTextBox";
            SecretKeyTextBox.PlaceholderText = "Here will be displayed the secret key.";
            SecretKeyTextBox.ReadOnly = true;
            SecretKeyTextBox.Size = new Size(375, 68);
            SecretKeyTextBox.TabIndex = 13;
            // 
            // IVTextBox
            // 
            IVTextBox.Anchor = AnchorStyles.Bottom;
            IVTextBox.BackColor = SystemColors.Window;
            IVTextBox.Location = new Point(650, 218);
            IVTextBox.Multiline = true;
            IVTextBox.Name = "IVTextBox";
            IVTextBox.PlaceholderText = "Here will be displayed the IV.";
            IVTextBox.ReadOnly = true;
            IVTextBox.Size = new Size(375, 68);
            IVTextBox.TabIndex = 14;
            // 
            // KeyChatLengthLabel
            // 
            KeyChatLengthLabel.Anchor = AnchorStyles.Bottom;
            KeyChatLengthLabel.AutoSize = true;
            KeyChatLengthLabel.BackColor = Color.SlateGray;
            KeyChatLengthLabel.CustomBackground = true;
            KeyChatLengthLabel.CustomForeColor = true;
            KeyChatLengthLabel.Font = new Font("Segoe UI", 2F, FontStyle.Regular, GraphicsUnit.Point);
            KeyChatLengthLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            KeyChatLengthLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            KeyChatLengthLabel.ForeColor = Color.Black;
            KeyChatLengthLabel.ImageAlign = ContentAlignment.MiddleLeft;
            KeyChatLengthLabel.Location = new Point(717, 80);
            KeyChatLengthLabel.Name = "KeyChatLengthLabel";
            KeyChatLengthLabel.Size = new Size(84, 15);
            KeyChatLengthLabel.TabIndex = 17;
            KeyChatLengthLabel.Text = "(24 characters)";
            KeyChatLengthLabel.TextAlign = ContentAlignment.MiddleLeft;
            KeyChatLengthLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel3
            // 
            metroLabel3.AutoSize = true;
            metroLabel3.BackColor = Color.SlateGray;
            metroLabel3.CustomBackground = true;
            metroLabel3.CustomForeColor = true;
            metroLabel3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel3.ForeColor = Color.Black;
            metroLabel3.ImageAlign = ContentAlignment.MiddleLeft;
            metroLabel3.Location = new Point(129, 54);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new Size(57, 19);
            metroLabel3.TabIndex = 9;
            metroLabel3.Text = "Decrypt";
            metroLabel3.TextAlign = ContentAlignment.MiddleLeft;
            metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.BackColor = Color.SlateGray;
            metroLabel2.CustomBackground = true;
            metroLabel2.CustomForeColor = true;
            metroLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel2.ForeColor = Color.Black;
            metroLabel2.ImageAlign = ContentAlignment.MiddleLeft;
            metroLabel2.Location = new Point(12, 54);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(55, 19);
            metroLabel2.TabIndex = 8;
            metroLabel2.Text = "Encrypt";
            metroLabel2.TextAlign = ContentAlignment.MiddleLeft;
            metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // EncryptDecryptToggle
            // 
            EncryptDecryptToggle.AutoSize = true;
            EncryptDecryptToggle.DisplayStatus = false;
            EncryptDecryptToggle.Location = new Point(73, 54);
            EncryptDecryptToggle.Name = "EncryptDecryptToggle";
            EncryptDecryptToggle.Size = new Size(50, 19);
            EncryptDecryptToggle.TabIndex = 7;
            EncryptDecryptToggle.Text = "Off";
            EncryptDecryptToggle.UseVisualStyleBackColor = true;
            EncryptDecryptToggle.CheckedChanged += EncryptDecryptToggle_CheckedChanged;
            // 
            // EncryptionMethodComboBox
            // 
            EncryptionMethodComboBox.FormattingEnabled = true;
            EncryptionMethodComboBox.ItemHeight = 23;
            EncryptionMethodComboBox.Items.AddRange(new object[] { "AES-128", "AES-256" });
            EncryptionMethodComboBox.Location = new Point(334, 49);
            EncryptionMethodComboBox.Name = "EncryptionMethodComboBox";
            EncryptionMethodComboBox.Size = new Size(121, 29);
            EncryptionMethodComboBox.TabIndex = 16;
            EncryptionMethodComboBox.SelectedIndexChanged += EncryptionMethodComboBox_SelectedIndexChanged;
            // 
            // metroLabel6
            // 
            metroLabel6.AutoSize = true;
            metroLabel6.BackColor = Color.SlateGray;
            metroLabel6.CustomBackground = true;
            metroLabel6.CustomForeColor = true;
            metroLabel6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel6.ForeColor = Color.Black;
            metroLabel6.ImageAlign = ContentAlignment.MiddleLeft;
            metroLabel6.Location = new Point(201, 54);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new Size(127, 19);
            metroLabel6.TabIndex = 17;
            metroLabel6.Text = "Encryption Method";
            metroLabel6.TextAlign = ContentAlignment.MiddleLeft;
            metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel7
            // 
            metroLabel7.Anchor = AnchorStyles.Bottom;
            metroLabel7.AutoSize = true;
            metroLabel7.BackColor = Color.SlateGray;
            metroLabel7.CustomBackground = true;
            metroLabel7.CustomForeColor = true;
            metroLabel7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel7.ForeColor = Color.Black;
            metroLabel7.ImageAlign = ContentAlignment.MiddleLeft;
            metroLabel7.Location = new Point(650, 196);
            metroLabel7.Name = "metroLabel7";
            metroLabel7.Size = new Size(150, 19);
            metroLabel7.TabIndex = 18;
            metroLabel7.Text = "Initialization Vector (IV)";
            metroLabel7.TextAlign = ContentAlignment.MiddleLeft;
            metroLabel7.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(182, 41);
            label1.Name = "label1";
            label1.Size = new Size(23, 37);
            label1.TabIndex = 19;
            label1.Text = "|";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Bottom;
            PasswordTextBox.Location = new Point(12, 218);
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.PlaceholderText = "Write a password here that will be used to generate a key and a IV.";
            PasswordTextBox.Size = new Size(375, 68);
            PasswordTextBox.TabIndex = 20;
            // 
            // metroLabel8
            // 
            metroLabel8.Anchor = AnchorStyles.Bottom;
            metroLabel8.AutoSize = true;
            metroLabel8.BackColor = Color.SlateGray;
            metroLabel8.CustomBackground = true;
            metroLabel8.CustomForeColor = true;
            metroLabel8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel8.ForeColor = Color.Black;
            metroLabel8.ImageAlign = ContentAlignment.MiddleLeft;
            metroLabel8.Location = new Point(12, 196);
            metroLabel8.Name = "metroLabel8";
            metroLabel8.Size = new Size(67, 19);
            metroLabel8.TabIndex = 21;
            metroLabel8.Text = "Password";
            metroLabel8.TextAlign = ContentAlignment.MiddleLeft;
            metroLabel8.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1037, 622);
            ControlBox = false;
            Controls.Add(metroLabel8);
            Controls.Add(PasswordTextBox);
            Controls.Add(label1);
            Controls.Add(metroLabel7);
            Controls.Add(metroLabel6);
            Controls.Add(KeyChatLengthLabel);
            Controls.Add(EncryptionMethodComboBox);
            Controls.Add(EncryptDecryptToggle);
            Controls.Add(IVTextBox);
            Controls.Add(SecretKeyTextBox);
            Controls.Add(metroLabel2);
            Controls.Add(metroLabel3);
            Controls.Add(metroLabel5);
            Controls.Add(GoButton);
            Controls.Add(metroLabel4);
            Controls.Add(OutputTextBox);
            Controls.Add(metroLabel1);
            Controls.Add(InputTextBox);
            Controls.Add(MinimizeButton);
            Controls.Add(CloseButton);
            Controls.Add(Title);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Encryption/Decryption Tool";
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroLabel Title;
        private Button CloseButton;
        private Button MinimizeButton;
        private TextBox InputTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private TextBox OutputTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton GoButton;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private TextBox SecretKeyTextBox;
        private TextBox IVTextBox;
        private MetroFramework.Controls.MetroLabel KeyChatLengthLabel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle EncryptDecryptToggle;
        private MetroFramework.Controls.MetroComboBox EncryptionMethodComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private Label label1;
        private TextBox PasswordTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}
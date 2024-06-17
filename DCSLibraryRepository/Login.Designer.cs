namespace DCSLibraryRepository
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            UsernameField = new MaterialSkin.Controls.MaterialTextBox2();
            PasswordField = new MaterialSkin.Controls.MaterialTextBox2();
            LoginBtn = new MaterialSkin.Controls.MaterialButton();
            CreateAccountBtn = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ShowPasswordButton = new MaterialSkin.Controls.MaterialRadioButton();
            Title = new MaterialSkin.Controls.MaterialLabel();
            pictureBox1 = new PictureBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UsernameField
            // 
            UsernameField.Anchor = AnchorStyles.Top;
            UsernameField.AnimateReadOnly = false;
            UsernameField.BackgroundImageLayout = ImageLayout.None;
            UsernameField.CharacterCasing = CharacterCasing.Normal;
            UsernameField.Depth = 0;
            UsernameField.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            UsernameField.HideSelection = true;
            UsernameField.Hint = "Username";
            UsernameField.LeadingIcon = null;
            UsernameField.Location = new Point(42, 189);
            UsernameField.MaxLength = 32767;
            UsernameField.MouseState = MaterialSkin.MouseState.OUT;
            UsernameField.Name = "UsernameField";
            UsernameField.PasswordChar = '\0';
            UsernameField.PrefixSuffixText = null;
            UsernameField.ReadOnly = false;
            UsernameField.RightToLeft = RightToLeft.No;
            UsernameField.SelectedText = "";
            UsernameField.SelectionLength = 0;
            UsernameField.SelectionStart = 0;
            UsernameField.ShortcutsEnabled = true;
            UsernameField.Size = new Size(312, 48);
            UsernameField.TabIndex = 8;
            UsernameField.TabStop = false;
            UsernameField.TextAlign = HorizontalAlignment.Left;
            UsernameField.TrailingIcon = null;
            UsernameField.UseSystemPasswordChar = false;
            // 
            // PasswordField
            // 
            PasswordField.Anchor = AnchorStyles.Top;
            PasswordField.AnimateReadOnly = false;
            PasswordField.BackgroundImageLayout = ImageLayout.None;
            PasswordField.CharacterCasing = CharacterCasing.Normal;
            PasswordField.Depth = 0;
            PasswordField.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PasswordField.HideSelection = true;
            PasswordField.Hint = "Password";
            PasswordField.LeadingIcon = null;
            PasswordField.Location = new Point(42, 266);
            PasswordField.Margin = new Padding(0);
            PasswordField.MaxLength = 32767;
            PasswordField.MouseState = MaterialSkin.MouseState.OUT;
            PasswordField.Name = "PasswordField";
            PasswordField.PasswordChar = '\0';
            PasswordField.PrefixSuffixText = null;
            PasswordField.ReadOnly = false;
            PasswordField.RightToLeft = RightToLeft.No;
            PasswordField.SelectedText = "";
            PasswordField.SelectionLength = 0;
            PasswordField.SelectionStart = 0;
            PasswordField.ShortcutsEnabled = true;
            PasswordField.Size = new Size(312, 48);
            PasswordField.TabIndex = 9;
            PasswordField.TabStop = false;
            PasswordField.TextAlign = HorizontalAlignment.Left;
            PasswordField.TrailingIcon = null;
            PasswordField.UseSystemPasswordChar = false;
            // 
            // LoginBtn
            // 
            LoginBtn.Anchor = AnchorStyles.Top;
            LoginBtn.AutoSize = false;
            LoginBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoginBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            LoginBtn.Depth = 0;
            LoginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.HighEmphasis = true;
            LoginBtn.Icon = null;
            LoginBtn.Location = new Point(42, 397);
            LoginBtn.Margin = new Padding(4, 6, 4, 6);
            LoginBtn.MouseState = MaterialSkin.MouseState.HOVER;
            LoginBtn.Name = "LoginBtn";
            LoginBtn.NoAccentTextColor = Color.Empty;
            LoginBtn.Size = new Size(312, 36);
            LoginBtn.TabIndex = 10;
            LoginBtn.Text = "Login";
            LoginBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            LoginBtn.UseAccentColor = false;
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginPressed;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Anchor = AnchorStyles.Top;
            CreateAccountBtn.AutoSize = true;
            CreateAccountBtn.Depth = 0;
            CreateAccountBtn.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CreateAccountBtn.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            CreateAccountBtn.HighEmphasis = true;
            CreateAccountBtn.Location = new Point(137, 485);
            CreateAccountBtn.MouseState = MaterialSkin.MouseState.HOVER;
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(130, 17);
            CreateAccountBtn.TabIndex = 13;
            CreateAccountBtn.Text = "Create New Account";
            CreateAccountBtn.UseAccent = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Top;
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            materialLabel1.Location = new Point(194, 451);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(14, 17);
            materialLabel1.TabIndex = 12;
            materialLabel1.Text = "or";
            // 
            // ShowPasswordButton
            // 
            ShowPasswordButton.Anchor = AnchorStyles.Top;
            ShowPasswordButton.AutoSize = true;
            ShowPasswordButton.Depth = 0;
            ShowPasswordButton.Location = new Point(42, 342);
            ShowPasswordButton.Margin = new Padding(0);
            ShowPasswordButton.MouseLocation = new Point(-1, -1);
            ShowPasswordButton.MouseState = MaterialSkin.MouseState.HOVER;
            ShowPasswordButton.Name = "ShowPasswordButton";
            ShowPasswordButton.Ripple = true;
            ShowPasswordButton.Size = new Size(149, 37);
            ShowPasswordButton.TabIndex = 11;
            ShowPasswordButton.TabStop = true;
            ShowPasswordButton.Text = "Show Password";
            ShowPasswordButton.UseVisualStyleBackColor = true;
            ShowPasswordButton.Click += ShowPasswordPressed;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top;
            Title.AutoSize = true;
            Title.Depth = 0;
            Title.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            Title.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            Title.HighEmphasis = true;
            Title.Location = new Point(27, 112);
            Title.MouseState = MaterialSkin.MouseState.HOVER;
            Title.Name = "Title";
            Title.Size = new Size(346, 41);
            Title.TabIndex = 12;
            Title.Text = "DCS Library Repository";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(412, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(412, 466);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(158, 36);
            materialButton1.TabIndex = 14;
            materialButton1.Text = "materialButton1";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(745, 541);
            Controls.Add(materialButton1);
            Controls.Add(CreateAccountBtn);
            Controls.Add(pictureBox1);
            Controls.Add(materialLabel1);
            Controls.Add(Title);
            Controls.Add(ShowPasswordButton);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordField);
            Controls.Add(UsernameField);
            HelpButton = true;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 UsernameField;
        private MaterialSkin.Controls.MaterialTextBox2 PasswordField;
        private MaterialSkin.Controls.MaterialButton LoginBtn;
        private MaterialSkin.Controls.MaterialLabel Title;
        private MaterialSkin.Controls.MaterialRadioButton ShowPasswordButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel CreateAccountBtn;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}

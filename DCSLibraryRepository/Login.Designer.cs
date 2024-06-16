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
            UsernameField = new MaterialSkin.Controls.MaterialTextBox2();
            PasswordField = new MaterialSkin.Controls.MaterialTextBox2();
            LoginBtn = new MaterialSkin.Controls.MaterialButton();
            panel1 = new Panel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ShowPasswordButton = new MaterialSkin.Controls.MaterialRadioButton();
            Title = new MaterialSkin.Controls.MaterialLabel();
            panel1.SuspendLayout();
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
            UsernameField.Location = new Point(127, 14);
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
            PasswordField.Location = new Point(127, 91);
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
            LoginBtn.Location = new Point(127, 211);
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(ShowPasswordButton);
            panel1.Controls.Add(PasswordField);
            panel1.Controls.Add(UsernameField);
            panel1.Controls.Add(LoginBtn);
            panel1.Location = new Point(-30, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(561, 333);
            panel1.TabIndex = 11;
            // 
            // materialLabel2
            // 
            materialLabel2.Anchor = AnchorStyles.Top;
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel2.HighEmphasis = true;
            materialLabel2.Location = new Point(222, 299);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(130, 17);
            materialLabel2.TabIndex = 13;
            materialLabel2.Text = "Create New Account";
            materialLabel2.UseAccent = true;
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Top;
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            materialLabel1.Location = new Point(279, 265);
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
            ShowPasswordButton.Location = new Point(127, 156);
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
            Title.Location = new Point(82, 89);
            Title.MouseState = MaterialSkin.MouseState.HOVER;
            Title.Name = "Title";
            Title.Size = new Size(346, 41);
            Title.TabIndex = 12;
            Title.Text = "DCS Library Repository";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(515, 530);
            Controls.Add(Title);
            Controls.Add(panel1);
            HelpButton = true;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 UsernameField;
        private MaterialSkin.Controls.MaterialTextBox2 PasswordField;
        private MaterialSkin.Controls.MaterialButton LoginBtn;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel Title;
        private MaterialSkin.Controls.MaterialRadioButton ShowPasswordButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        
    }
}

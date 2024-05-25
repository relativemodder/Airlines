namespace Airlines.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            TitleLabel = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            SignInButton = new Button();
            SignUpButton = new Button();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleLabel.Font = new Font("Segoe UI", 20F);
            TitleLabel.Location = new Point(57, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(715, 37);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Войти в панель управления";
            TitleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UsernameTextBox.Font = new Font("Segoe UI", 16F);
            UsernameTextBox.Location = new Point(57, 72);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.PlaceholderText = "Пользователь";
            UsernameTextBox.Size = new Size(715, 36);
            UsernameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.Font = new Font("Segoe UI", 16F);
            PasswordTextBox.Location = new Point(57, 127);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "Пароль";
            PasswordTextBox.Size = new Size(715, 36);
            PasswordTextBox.TabIndex = 2;
            PasswordTextBox.UseSystemPasswordChar = true;
            PasswordTextBox.KeyDown += PasswordTextBox_KeyDown;
            // 
            // SignInButton
            // 
            SignInButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SignInButton.BackColor = Color.Black;
            SignInButton.FlatStyle = FlatStyle.Flat;
            SignInButton.Font = new Font("Segoe UI", 16F);
            SignInButton.ForeColor = Color.White;
            SignInButton.Location = new Point(57, 185);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(715, 48);
            SignInButton.TabIndex = 3;
            SignInButton.Text = "Войти";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            // 
            // SignUpButton
            // 
            SignUpButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SignUpButton.BackColor = Color.White;
            SignUpButton.FlatStyle = FlatStyle.Flat;
            SignUpButton.Font = new Font("Segoe UI", 16F);
            SignUpButton.ForeColor = Color.Black;
            SignUpButton.Location = new Point(57, 252);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(715, 48);
            SignUpButton.TabIndex = 4;
            SignUpButton.Text = "Регистрация как пассажира";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(832, 317);
            Controls.Add(SignUpButton);
            Controls.Add(SignInButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(TitleLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Button SignInButton;
        private Button SignUpButton;
    }
}
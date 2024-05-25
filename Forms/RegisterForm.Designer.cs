namespace Airlines.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            UsernameTextBox = new TextBox();
            label1 = new Label();
            FullNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            SignUpButton = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UsernameTextBox.Font = new Font("Segoe UI", 16F);
            UsernameTextBox.Location = new Point(12, 63);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.PlaceholderText = "Пользователь";
            UsernameTextBox.Size = new Size(474, 36);
            UsernameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(474, 37);
            label1.TabIndex = 3;
            label1.Text = "Регистрация как клиента";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.Font = new Font("Segoe UI", 16F);
            FullNameTextBox.Location = new Point(12, 111);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.PlaceholderText = "ФИО";
            FullNameTextBox.Size = new Size(474, 36);
            FullNameTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.Font = new Font("Segoe UI", 16F);
            PasswordTextBox.Location = new Point(12, 160);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "Пароль";
            PasswordTextBox.Size = new Size(474, 36);
            PasswordTextBox.TabIndex = 5;
            PasswordTextBox.UseSystemPasswordChar = true;
            PasswordTextBox.KeyDown += PasswordTextBox_KeyDown;
            // 
            // SignUpButton
            // 
            SignUpButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SignUpButton.BackColor = Color.Black;
            SignUpButton.FlatStyle = FlatStyle.Flat;
            SignUpButton.Font = new Font("Segoe UI", 16F);
            SignUpButton.ForeColor = Color.White;
            SignUpButton.Location = new Point(12, 213);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(233, 48);
            SignUpButton.TabIndex = 6;
            SignUpButton.Text = "Зарегистрироваться";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BackButton.BackColor = Color.White;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 16F);
            BackButton.ForeColor = Color.Black;
            BackButton.Location = new Point(251, 213);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(235, 48);
            BackButton.TabIndex = 7;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(498, 273);
            Controls.Add(BackButton);
            Controls.Add(SignUpButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(FullNameTextBox);
            Controls.Add(label1);
            Controls.Add(UsernameTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterForm";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameTextBox;
        private Label label1;
        private TextBox FullNameTextBox;
        private TextBox PasswordTextBox;
        private Button SignUpButton;
        private Button BackButton;
    }
}
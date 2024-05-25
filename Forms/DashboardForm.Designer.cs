namespace Airlines.Forms
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            TitleLabel = new Label();
            SignOutButton = new Button();
            FullNameLabel = new Label();
            RoleLabel = new Label();
            AvatarPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)AvatarPictureBox).BeginInit();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleLabel.FlatStyle = FlatStyle.Flat;
            TitleLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(190, 20);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(443, 37);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Панель управления";
            TitleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // SignOutButton
            // 
            SignOutButton.BackColor = Color.Black;
            SignOutButton.FlatStyle = FlatStyle.Flat;
            SignOutButton.Font = new Font("Segoe UI", 16F);
            SignOutButton.ForeColor = Color.White;
            SignOutButton.Location = new Point(12, 16);
            SignOutButton.Name = "SignOutButton";
            SignOutButton.Size = new Size(156, 48);
            SignOutButton.TabIndex = 7;
            SignOutButton.Text = "Выйти";
            SignOutButton.UseVisualStyleBackColor = false;
            SignOutButton.Click += SignOutButton_Click;
            // 
            // FullNameLabel
            // 
            FullNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FullNameLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FullNameLabel.Location = new Point(542, 20);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(206, 20);
            FullNameLabel.TabIndex = 8;
            FullNameLabel.Text = "Имя Фамилия";
            FullNameLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // RoleLabel
            // 
            RoleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RoleLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoleLabel.Location = new Point(572, 40);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(176, 17);
            RoleLabel.TabIndex = 9;
            RoleLabel.Text = "Роль";
            RoleLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // AvatarPictureBox
            // 
            AvatarPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AvatarPictureBox.Image = (Image)resources.GetObject("AvatarPictureBox.Image");
            AvatarPictureBox.Location = new Point(754, 20);
            AvatarPictureBox.Name = "AvatarPictureBox";
            AvatarPictureBox.Size = new Size(34, 37);
            AvatarPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            AvatarPictureBox.TabIndex = 10;
            AvatarPictureBox.TabStop = false;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 316);
            Controls.Add(AvatarPictureBox);
            Controls.Add(RoleLabel);
            Controls.Add(FullNameLabel);
            Controls.Add(SignOutButton);
            Controls.Add(TitleLabel);
            Name = "DashboardForm";
            Text = "Панель управления";
            ((System.ComponentModel.ISupportInitialize)AvatarPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label TitleLabel;
        private Button SignOutButton;
        private Label FullNameLabel;
        private Label RoleLabel;
        private PictureBox AvatarPictureBox;
    }
}
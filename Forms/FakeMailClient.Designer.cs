namespace Airlines.Forms
{
    partial class FakeMailClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FakeMailClient));
            TitleLabel = new Label();
            FromLabel = new Label();
            FromTextBox = new TextBox();
            ToLabel = new Label();
            ToTextBox = new TextBox();
            MessageBodyRTFBox = new RichTextBox();
            SignInButton = new Button();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleLabel.Font = new Font("Segoe UI", 20F);
            TitleLabel.Location = new Point(12, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(516, 37);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Fake Mail Client";
            TitleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // FromLabel
            // 
            FromLabel.AutoSize = true;
            FromLabel.Font = new Font("Segoe UI", 13F);
            FromLabel.Location = new Point(12, 46);
            FromLabel.Name = "FromLabel";
            FromLabel.Size = new Size(37, 25);
            FromLabel.TabIndex = 1;
            FromLabel.Text = "От:";
            // 
            // FromTextBox
            // 
            FromTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FromTextBox.BackColor = Color.White;
            FromTextBox.Font = new Font("Segoe UI", 13F);
            FromTextBox.Location = new Point(12, 74);
            FromTextBox.Name = "FromTextBox";
            FromTextBox.PlaceholderText = "Имя пользователя";
            FromTextBox.ReadOnly = true;
            FromTextBox.Size = new Size(516, 31);
            FromTextBox.TabIndex = 2;
            // 
            // ToLabel
            // 
            ToLabel.AutoSize = true;
            ToLabel.Font = new Font("Segoe UI", 13F);
            ToLabel.Location = new Point(12, 125);
            ToLabel.Name = "ToLabel";
            ToLabel.Size = new Size(59, 25);
            ToLabel.TabIndex = 3;
            ToLabel.Text = "Кому:";
            // 
            // ToTextBox
            // 
            ToTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ToTextBox.BackColor = Color.White;
            ToTextBox.Font = new Font("Segoe UI", 13F);
            ToTextBox.Location = new Point(12, 153);
            ToTextBox.Name = "ToTextBox";
            ToTextBox.PlaceholderText = "Руководство";
            ToTextBox.Size = new Size(516, 31);
            ToTextBox.TabIndex = 4;
            ToTextBox.Text = "Руководство";
            // 
            // MessageBodyRTFBox
            // 
            MessageBodyRTFBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MessageBodyRTFBox.BackColor = Color.White;
            MessageBodyRTFBox.Font = new Font("Segoe UI", 13F);
            MessageBodyRTFBox.Location = new Point(12, 218);
            MessageBodyRTFBox.Name = "MessageBodyRTFBox";
            MessageBodyRTFBox.Size = new Size(516, 196);
            MessageBodyRTFBox.TabIndex = 5;
            MessageBodyRTFBox.Text = "";
            // 
            // SignInButton
            // 
            SignInButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SignInButton.BackColor = Color.Black;
            SignInButton.FlatStyle = FlatStyle.Flat;
            SignInButton.Font = new Font("Segoe UI", 16F);
            SignInButton.ForeColor = Color.White;
            SignInButton.Location = new Point(325, 433);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(203, 48);
            SignInButton.TabIndex = 6;
            SignInButton.Text = "Отправить";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            // 
            // FakeMailClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(540, 493);
            Controls.Add(SignInButton);
            Controls.Add(MessageBodyRTFBox);
            Controls.Add(ToTextBox);
            Controls.Add(ToLabel);
            Controls.Add(FromTextBox);
            Controls.Add(FromLabel);
            Controls.Add(TitleLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FakeMailClient";
            Text = "FakeMailClient";
            Load += FakeMailClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Label FromLabel;
        private TextBox FromTextBox;
        private Label ToLabel;
        private TextBox ToTextBox;
        private RichTextBox MessageBodyRTFBox;
        private Button SignInButton;
    }
}
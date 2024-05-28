namespace Airlines.Forms
{
    partial class BuyTicketForm
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
            BackButton = new Button();
            ExpeditorsHint = new Label();
            FlightComboBox = new ComboBox();
            TitleLabel = new Label();
            ContactExpeditorButton = new Button();
            label1 = new Label();
            SubmitButton = new Button();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 16F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(156, 48);
            BackButton.TabIndex = 8;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // ExpeditorsHint
            // 
            ExpeditorsHint.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ExpeditorsHint.FlatStyle = FlatStyle.Popup;
            ExpeditorsHint.Font = new Font("Segoe UI", 13F);
            ExpeditorsHint.Location = new Point(16, 232);
            ExpeditorsHint.Name = "ExpeditorsHint";
            ExpeditorsHint.Size = new Size(338, 62);
            ExpeditorsHint.TabIndex = 11;
            ExpeditorsHint.Text = "Для оформления груза (багажа), обратитесь к экспедиторам";
            // 
            // FlightComboBox
            // 
            FlightComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FlightComboBox.Font = new Font("Segoe UI", 13F);
            FlightComboBox.FormattingEnabled = true;
            FlightComboBox.Location = new Point(16, 181);
            FlightComboBox.Name = "FlightComboBox";
            FlightComboBox.Size = new Size(354, 31);
            FlightComboBox.TabIndex = 10;
            FlightComboBox.Text = "Выберите рейс";
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleLabel.Font = new Font("Segoe UI", 20F);
            TitleLabel.Location = new Point(16, 74);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(354, 80);
            TitleLabel.TabIndex = 9;
            TitleLabel.Text = "Купить и забронировать билет на рейс";
            // 
            // ContactExpeditorButton
            // 
            ContactExpeditorButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ContactExpeditorButton.BackColor = Color.White;
            ContactExpeditorButton.FlatStyle = FlatStyle.Flat;
            ContactExpeditorButton.Font = new Font("Segoe UI", 13F);
            ContactExpeditorButton.ForeColor = Color.Black;
            ContactExpeditorButton.Location = new Point(16, 297);
            ContactExpeditorButton.Name = "ContactExpeditorButton";
            ContactExpeditorButton.Size = new Size(354, 48);
            ContactExpeditorButton.TabIndex = 12;
            ContactExpeditorButton.Text = "Связаться";
            ContactExpeditorButton.UseVisualStyleBackColor = false;
            ContactExpeditorButton.Click += ContactExpeditorButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 357);
            label1.Name = "label1";
            label1.Size = new Size(216, 15);
            label1.TabIndex = 13;
            label1.Text = "Цена установится после оформления";
            // 
            // SubmitButton
            // 
            SubmitButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SubmitButton.BackColor = Color.Black;
            SubmitButton.FlatStyle = FlatStyle.Flat;
            SubmitButton.Font = new Font("Segoe UI", 13F);
            SubmitButton.ForeColor = Color.White;
            SubmitButton.Location = new Point(16, 385);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(354, 48);
            SubmitButton.TabIndex = 14;
            SubmitButton.Text = "Оформить";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // BuyTicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(382, 445);
            Controls.Add(SubmitButton);
            Controls.Add(label1);
            Controls.Add(ContactExpeditorButton);
            Controls.Add(FlightComboBox);
            Controls.Add(TitleLabel);
            Controls.Add(BackButton);
            Controls.Add(ExpeditorsHint);
            Name = "BuyTicketForm";
            Text = "Купить билет";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Label ExpeditorsHint;
        private ComboBox FlightComboBox;
        private Label TitleLabel;
        private Button ContactExpeditorButton;
        private Label label1;
        private Button SubmitButton;
    }
}
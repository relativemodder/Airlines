namespace Airlines.Forms
{
    partial class SalesAnalysisForm
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
            TitleLabel = new Label();
            BackButton = new Button();
            SalesAnalysisLabel = new Label();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleLabel.Font = new Font("Segoe UI", 20F);
            TitleLabel.Location = new Point(12, 63);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(496, 52);
            TitleLabel.TabIndex = 13;
            TitleLabel.Text = "Анализ продаж";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            BackButton.TabIndex = 12;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // SalesAnalysisLabel
            // 
            SalesAnalysisLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SalesAnalysisLabel.Font = new Font("Segoe UI", 13F);
            SalesAnalysisLabel.Location = new Point(26, 147);
            SalesAnalysisLabel.Name = "SalesAnalysisLabel";
            SalesAnalysisLabel.Size = new Size(467, 392);
            SalesAnalysisLabel.TabIndex = 14;
            SalesAnalysisLabel.Text = "Анализ продаж";
            // 
            // SalesAnalysisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(520, 563);
            Controls.Add(SalesAnalysisLabel);
            Controls.Add(TitleLabel);
            Controls.Add(BackButton);
            Name = "SalesAnalysisForm";
            Text = "Анализ продаж";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Label TitleLabel;
        private Button BackButton;
        private Label SalesAnalysisLabel;
    }
}
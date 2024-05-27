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
            TitleLabel = new Label();
            FlightComboBox = new ComboBox();
            ExpeditorsHint = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
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
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleLabel.Font = new Font("Segoe UI", 20F);
            TitleLabel.Location = new Point(3, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(354, 80);
            TitleLabel.TabIndex = 9;
            TitleLabel.Text = "Купить и забронировать билет на рейс";
            // 
            // FlightComboBox
            // 
            FlightComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FlightComboBox.Font = new Font("Segoe UI", 13F);
            FlightComboBox.FormattingEnabled = true;
            FlightComboBox.Location = new Point(3, 83);
            FlightComboBox.Name = "FlightComboBox";
            FlightComboBox.Size = new Size(338, 31);
            FlightComboBox.TabIndex = 10;
            FlightComboBox.Text = "Выберите рейс";
            // 
            // ExpeditorsHint
            // 
            ExpeditorsHint.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ExpeditorsHint.Font = new Font("Segoe UI", 13F);
            ExpeditorsHint.Location = new Point(3, 117);
            ExpeditorsHint.Name = "ExpeditorsHint";
            ExpeditorsHint.Size = new Size(338, 62);
            ExpeditorsHint.TabIndex = 11;
            ExpeditorsHint.Text = "Для оформления груза (багажа), обратитесь к экспедиторам";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(TitleLabel);
            flowLayoutPanel1.Controls.Add(FlightComboBox);
            flowLayoutPanel1.Controls.Add(ExpeditorsHint);
            flowLayoutPanel1.Location = new Point(12, 81);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(358, 352);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // BuyTicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(382, 445);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(BackButton);
            Name = "BuyTicketForm";
            Text = "Купить билет";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BackButton;
        private Label TitleLabel;
        private ComboBox FlightComboBox;
        private Label ExpeditorsHint;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
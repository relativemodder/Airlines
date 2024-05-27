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
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 16F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(17, 20);
            BackButton.Margin = new Padding(4, 5, 4, 5);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(223, 80);
            BackButton.TabIndex = 8;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleLabel.Font = new Font("Segoe UI", 20F);
            TitleLabel.Location = new Point(17, 148);
            TitleLabel.Margin = new Padding(4, 0, 4, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(536, 133);
            TitleLabel.TabIndex = 9;
            TitleLabel.Text = "Купить и забронировать билет на рейс";
            // 
            // FlightComboBox
            // 
            FlightComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FlightComboBox.Font = new Font("Segoe UI", 13F);
            FlightComboBox.FormattingEnabled = true;
            FlightComboBox.Location = new Point(17, 286);
            FlightComboBox.Margin = new Padding(4, 5, 4, 5);
            FlightComboBox.Name = "FlightComboBox";
            FlightComboBox.Size = new Size(534, 44);
            FlightComboBox.TabIndex = 10;
            FlightComboBox.Text = "Выберите рейс";
            // 
            // BuyTicketForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 760);
            Controls.Add(FlightComboBox);
            Controls.Add(TitleLabel);
            Controls.Add(BackButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "BuyTicketForm";
            Text = "Купить билет";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button BackButton;
        private Label TitleLabel;
        private ComboBox FlightComboBox;
    }
}
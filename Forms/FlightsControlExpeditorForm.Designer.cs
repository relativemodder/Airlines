namespace Airlines.Forms
{
    partial class FlightsControlExpeditorForm
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
            FlightsList = new ListBox();
            AddFlightButton = new Button();
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
            BackButton.TabIndex = 9;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleLabel.Font = new Font("Segoe UI", 20F);
            TitleLabel.Location = new Point(12, 78);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(455, 54);
            TitleLabel.TabIndex = 10;
            TitleLabel.Text = "Управление рейсами";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FlightsList
            // 
            FlightsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FlightsList.Font = new Font("Segoe UI", 13F);
            FlightsList.FormattingEnabled = true;
            FlightsList.ItemHeight = 23;
            FlightsList.Location = new Point(12, 161);
            FlightsList.Name = "FlightsList";
            FlightsList.Size = new Size(456, 349);
            FlightsList.TabIndex = 11;
            // 
            // AddFlightButton
            // 
            AddFlightButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddFlightButton.BackColor = Color.Black;
            AddFlightButton.FlatStyle = FlatStyle.Flat;
            AddFlightButton.Font = new Font("Segoe UI", 20F);
            AddFlightButton.ForeColor = Color.White;
            AddFlightButton.Location = new Point(392, 519);
            AddFlightButton.Name = "AddFlightButton";
            AddFlightButton.Size = new Size(75, 52);
            AddFlightButton.TabIndex = 12;
            AddFlightButton.Text = "+";
            AddFlightButton.UseVisualStyleBackColor = false;
            AddFlightButton.Click += AddFlightButton_Click;
            // 
            // FlightsControlExpeditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(479, 580);
            Controls.Add(AddFlightButton);
            Controls.Add(FlightsList);
            Controls.Add(TitleLabel);
            Controls.Add(BackButton);
            Name = "FlightsControlExpeditorForm";
            Text = "Управление рейсами (Экспедитор)";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button BackButton;
        private Label TitleLabel;
        private ListBox FlightsList;
        private Button AddFlightButton;
    }
}
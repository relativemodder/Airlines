namespace Airlines.Forms
{
    partial class FlightsControlOperatorForm
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
            FlightsList.Location = new Point(12, 150);
            FlightsList.Name = "FlightsList";
            FlightsList.Size = new Size(456, 418);
            FlightsList.TabIndex = 11;
            FlightsList.MouseDoubleClick += FlightsList_MouseDoubleClick;
            // 
            // FlightsControlOperatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(479, 582);
            Controls.Add(FlightsList);
            Controls.Add(TitleLabel);
            Controls.Add(BackButton);
            Name = "FlightsControlOperatorForm";
            Text = "Управление рейсами (Диспетчер)";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button BackButton;
        private Label TitleLabel;
        private ListBox FlightsList;
    }
}
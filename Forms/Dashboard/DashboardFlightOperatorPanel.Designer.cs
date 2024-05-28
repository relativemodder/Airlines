namespace Airlines.Forms.Dashboard
{
    partial class DashboardFlightOperatorPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FlightsControlButton = new Button();
            ContactButton = new Button();
            SuspendLayout();
            // 
            // FlightsControlButton
            // 
            FlightsControlButton.BackColor = Color.White;
            FlightsControlButton.FlatStyle = FlatStyle.Flat;
            FlightsControlButton.Font = new Font("Segoe UI", 13F);
            FlightsControlButton.ForeColor = Color.Black;
            FlightsControlButton.Location = new Point(3, 3);
            FlightsControlButton.Name = "FlightsControlButton";
            FlightsControlButton.Size = new Size(305, 48);
            FlightsControlButton.TabIndex = 10;
            FlightsControlButton.Text = "Управление расписанием рейсов";
            FlightsControlButton.UseVisualStyleBackColor = false;
            FlightsControlButton.Click += FlightsControlButton_Click;
            // 
            // ContactButton
            // 
            ContactButton.BackColor = Color.White;
            ContactButton.FlatStyle = FlatStyle.Flat;
            ContactButton.Font = new Font("Segoe UI", 13F);
            ContactButton.ForeColor = Color.Black;
            ContactButton.Location = new Point(323, 3);
            ContactButton.Name = "ContactButton";
            ContactButton.Size = new Size(263, 48);
            ContactButton.TabIndex = 11;
            ContactButton.Text = "Связь с руководством";
            ContactButton.UseVisualStyleBackColor = false;
            ContactButton.Click += ContactButton_Click;
            // 
            // DashboardFlightOperatorPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ContactButton);
            Controls.Add(FlightsControlButton);
            Name = "DashboardFlightOperatorPanel";
            Size = new Size(592, 55);
            ResumeLayout(false);
        }

        #endregion

        private Button FlightsControlButton;
        private Button ContactButton;
    }
}

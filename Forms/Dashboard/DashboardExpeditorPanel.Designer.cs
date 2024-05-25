namespace Airlines.Forms.Dashboard
{
    partial class DashboardExpeditorPanel
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
            ContactButton = new Button();
            FlightsControlButton = new Button();
            ControlLoadButton = new Button();
            SuspendLayout();
            // 
            // ContactButton
            // 
            ContactButton.BackColor = Color.White;
            ContactButton.FlatStyle = FlatStyle.Flat;
            ContactButton.Font = new Font("Segoe UI", 13F);
            ContactButton.ForeColor = Color.Black;
            ContactButton.Location = new Point(607, 3);
            ContactButton.Name = "ContactButton";
            ContactButton.Size = new Size(263, 48);
            ContactButton.TabIndex = 13;
            ContactButton.Text = "Связь с руководством";
            ContactButton.UseVisualStyleBackColor = false;
            ContactButton.Click += ContactButton_Click;
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
            FlightsControlButton.TabIndex = 12;
            FlightsControlButton.Text = "Управление расписанием рейсов";
            FlightsControlButton.UseVisualStyleBackColor = false;
            // 
            // ControlLoadButton
            // 
            ControlLoadButton.BackColor = Color.White;
            ControlLoadButton.FlatStyle = FlatStyle.Flat;
            ControlLoadButton.Font = new Font("Segoe UI", 13F);
            ControlLoadButton.ForeColor = Color.Black;
            ControlLoadButton.Location = new Point(328, 3);
            ControlLoadButton.Name = "ControlLoadButton";
            ControlLoadButton.Size = new Size(260, 48);
            ControlLoadButton.TabIndex = 14;
            ControlLoadButton.Text = "Работа с грузами";
            ControlLoadButton.UseVisualStyleBackColor = false;
            // 
            // DashboardExpeditorPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ControlLoadButton);
            Controls.Add(ContactButton);
            Controls.Add(FlightsControlButton);
            Name = "DashboardExpeditorPanel";
            Size = new Size(877, 58);
            ResumeLayout(false);
        }

        #endregion

        private Button ContactButton;
        private Button FlightsControlButton;
        private Button ControlLoadButton;
    }
}

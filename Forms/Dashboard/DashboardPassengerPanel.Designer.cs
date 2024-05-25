namespace Airlines.Forms.Dashboard
{
    partial class DashboardPassengerPanel
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
            BuyButton = new Button();
            RequestTheLoadButton = new Button();
            SuspendLayout();
            // 
            // BuyButton
            // 
            BuyButton.BackColor = Color.White;
            BuyButton.FlatStyle = FlatStyle.Flat;
            BuyButton.Font = new Font("Segoe UI", 13F);
            BuyButton.ForeColor = Color.Black;
            BuyButton.Location = new Point(3, 3);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(357, 48);
            BuyButton.TabIndex = 8;
            BuyButton.Text = "Купить и забронировать билет на рейс";
            BuyButton.UseVisualStyleBackColor = false;
            // 
            // RequestTheLoadButton
            // 
            RequestTheLoadButton.BackColor = Color.White;
            RequestTheLoadButton.FlatStyle = FlatStyle.Flat;
            RequestTheLoadButton.Font = new Font("Segoe UI", 13F);
            RequestTheLoadButton.ForeColor = Color.Black;
            RequestTheLoadButton.Location = new Point(378, 3);
            RequestTheLoadButton.Name = "RequestTheLoadButton";
            RequestTheLoadButton.Size = new Size(294, 48);
            RequestTheLoadButton.TabIndex = 9;
            RequestTheLoadButton.Text = "Запрос на получение багажа";
            RequestTheLoadButton.UseVisualStyleBackColor = false;
            RequestTheLoadButton.Click += RequestTheLoadButton_Click;
            // 
            // DashboardPassengerPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(RequestTheLoadButton);
            Controls.Add(BuyButton);
            Name = "DashboardPassengerPanel";
            Size = new Size(685, 57);
            ResumeLayout(false);
        }

        #endregion

        private Button BuyButton;
        private Button RequestTheLoadButton;
    }
}

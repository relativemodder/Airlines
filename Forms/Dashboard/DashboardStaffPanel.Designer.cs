namespace Airlines.Forms.Dashboard
{
    partial class DashboardStaffPanel
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
            AnalysisButton = new Button();
            PhpMyAdmin = new Button();
            SuspendLayout();
            // 
            // AnalysisButton
            // 
            AnalysisButton.BackColor = Color.White;
            AnalysisButton.FlatStyle = FlatStyle.Flat;
            AnalysisButton.Font = new Font("Segoe UI", 13F);
            AnalysisButton.ForeColor = Color.Black;
            AnalysisButton.Location = new Point(3, 3);
            AnalysisButton.Name = "AnalysisButton";
            AnalysisButton.Size = new Size(357, 48);
            AnalysisButton.TabIndex = 9;
            AnalysisButton.Text = "Анализ продаж";
            AnalysisButton.UseVisualStyleBackColor = false;
            AnalysisButton.Click += AnalysisButton_Click;
            // 
            // PhpMyAdmin
            // 
            PhpMyAdmin.BackColor = Color.White;
            PhpMyAdmin.FlatStyle = FlatStyle.Flat;
            PhpMyAdmin.Font = new Font("Segoe UI", 13F);
            PhpMyAdmin.ForeColor = Color.Black;
            PhpMyAdmin.Location = new Point(366, 3);
            PhpMyAdmin.Name = "PhpMyAdmin";
            PhpMyAdmin.Size = new Size(263, 48);
            PhpMyAdmin.TabIndex = 10;
            PhpMyAdmin.Text = "phpMyAdmin";
            PhpMyAdmin.UseVisualStyleBackColor = false;
            PhpMyAdmin.Click += PhpMyAdmin_Click;
            // 
            // DashboardStaffPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(PhpMyAdmin);
            Controls.Add(AnalysisButton);
            Name = "DashboardStaffPanel";
            Size = new Size(683, 57);
            ResumeLayout(false);
        }

        #endregion

        private Button AnalysisButton;
        private Button PhpMyAdmin;
    }
}

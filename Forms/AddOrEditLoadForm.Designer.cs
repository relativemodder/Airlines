namespace Airlines.Forms
{
    partial class AddOrEditLoadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrEditLoadForm));
            SubmitButton = new Button();
            FlightComboBox = new ComboBox();
            WeightTextBox = new TextBox();
            TitleLabel = new Label();
            BackButton = new Button();
            CustomerComboBox = new ComboBox();
            DescriptionRTFBox = new RichTextBox();
            PriceTextBox = new TextBox();
            DeleteLoadButton = new Button();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            resources.ApplyResources(SubmitButton, "SubmitButton");
            SubmitButton.BackColor = Color.Black;
            SubmitButton.ForeColor = Color.White;
            SubmitButton.Name = "SubmitButton";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // FlightComboBox
            // 
            resources.ApplyResources(FlightComboBox, "FlightComboBox");
            FlightComboBox.FormattingEnabled = true;
            FlightComboBox.Name = "FlightComboBox";
            // 
            // WeightTextBox
            // 
            resources.ApplyResources(WeightTextBox, "WeightTextBox");
            WeightTextBox.BackColor = Color.White;
            WeightTextBox.Name = "WeightTextBox";
            // 
            // TitleLabel
            // 
            resources.ApplyResources(TitleLabel, "TitleLabel");
            TitleLabel.Name = "TitleLabel";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            resources.ApplyResources(BackButton, "BackButton");
            BackButton.ForeColor = Color.White;
            BackButton.Name = "BackButton";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // CustomerComboBox
            // 
            resources.ApplyResources(CustomerComboBox, "CustomerComboBox");
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Name = "CustomerComboBox";
            // 
            // DescriptionRTFBox
            // 
            resources.ApplyResources(DescriptionRTFBox, "DescriptionRTFBox");
            DescriptionRTFBox.Name = "DescriptionRTFBox";
            // 
            // PriceTextBox
            // 
            resources.ApplyResources(PriceTextBox, "PriceTextBox");
            PriceTextBox.BackColor = Color.White;
            PriceTextBox.Name = "PriceTextBox";
            // 
            // DeleteLoadButton
            // 
            resources.ApplyResources(DeleteLoadButton, "DeleteLoadButton");
            DeleteLoadButton.BackColor = Color.Red;
            DeleteLoadButton.ForeColor = Color.White;
            DeleteLoadButton.Name = "DeleteLoadButton";
            DeleteLoadButton.UseVisualStyleBackColor = false;
            DeleteLoadButton.Click += DeleteLoadButton_Click;
            // 
            // AddOrEditLoadForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteLoadButton);
            Controls.Add(PriceTextBox);
            Controls.Add(DescriptionRTFBox);
            Controls.Add(CustomerComboBox);
            Controls.Add(SubmitButton);
            Controls.Add(FlightComboBox);
            Controls.Add(WeightTextBox);
            Controls.Add(TitleLabel);
            Controls.Add(BackButton);
            Name = "AddOrEditLoadForm";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitButton;
        private ComboBox FlightComboBox;
        private TextBox WeightTextBox;
        private Label TitleLabel;
        private Button BackButton;
        private ComboBox CustomerComboBox;
        private RichTextBox DescriptionRTFBox;
        private TextBox PriceTextBox;
        private Button DeleteLoadButton;
    }
}
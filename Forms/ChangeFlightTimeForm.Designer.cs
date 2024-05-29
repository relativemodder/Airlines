namespace Airlines.Forms
{
    partial class ChangeFlightTimeForm
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
            SuggestedDateLabel = new Label();
            DepartureDateTimePicker = new DateTimePicker();
            DepartureLabel = new Label();
            label1 = new Label();
            DestinationDateTimePicker = new DateTimePicker();
            DeleteFlightButton = new Button();
            SubmitButton = new Button();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleLabel.Font = new Font("Segoe UI", 20F);
            TitleLabel.Location = new Point(12, 66);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(478, 46);
            TitleLabel.TabIndex = 12;
            TitleLabel.Text = "Изменить время рейса";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 16F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(12, 15);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(156, 48);
            BackButton.TabIndex = 11;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // SuggestedDateLabel
            // 
            SuggestedDateLabel.AutoSize = true;
            SuggestedDateLabel.Font = new Font("Segoe UI", 13F);
            SuggestedDateLabel.Location = new Point(12, 112);
            SuggestedDateLabel.Name = "SuggestedDateLabel";
            SuggestedDateLabel.Size = new Size(144, 25);
            SuggestedDateLabel.TabIndex = 13;
            SuggestedDateLabel.Text = "Желаемая дата: ";
            // 
            // DepartureDateTimePicker
            // 
            DepartureDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DepartureDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            DepartureDateTimePicker.Format = DateTimePickerFormat.Custom;
            DepartureDateTimePicker.Location = new Point(12, 190);
            DepartureDateTimePicker.Name = "DepartureDateTimePicker";
            DepartureDateTimePicker.Size = new Size(478, 23);
            DepartureDateTimePicker.TabIndex = 14;
            // 
            // DepartureLabel
            // 
            DepartureLabel.AutoSize = true;
            DepartureLabel.Font = new Font("Segoe UI", 13F);
            DepartureLabel.Location = new Point(12, 153);
            DepartureLabel.Name = "DepartureLabel";
            DepartureLabel.Size = new Size(283, 25);
            DepartureLabel.TabIndex = 15;
            DepartureLabel.Text = "Дата и время отправления (GMT)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(12, 239);
            label1.Name = "label1";
            label1.Size = new Size(258, 25);
            label1.TabIndex = 17;
            label1.Text = "Дата и время прибытия (GMT)";
            // 
            // DestinationDateTimePicker
            // 
            DestinationDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DestinationDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            DestinationDateTimePicker.Format = DateTimePickerFormat.Custom;
            DestinationDateTimePicker.Location = new Point(12, 273);
            DestinationDateTimePicker.Name = "DestinationDateTimePicker";
            DestinationDateTimePicker.Size = new Size(478, 23);
            DestinationDateTimePicker.TabIndex = 16;
            // 
            // DeleteFlightButton
            // 
            DeleteFlightButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DeleteFlightButton.BackColor = Color.Red;
            DeleteFlightButton.FlatStyle = FlatStyle.Flat;
            DeleteFlightButton.Font = new Font("Segoe UI", 16F);
            DeleteFlightButton.ForeColor = Color.White;
            DeleteFlightButton.ImeMode = ImeMode.NoControl;
            DeleteFlightButton.Location = new Point(12, 371);
            DeleteFlightButton.Name = "DeleteFlightButton";
            DeleteFlightButton.Size = new Size(478, 48);
            DeleteFlightButton.TabIndex = 35;
            DeleteFlightButton.Text = "Удалить";
            DeleteFlightButton.UseVisualStyleBackColor = false;
            DeleteFlightButton.Click += DeleteFlightButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SubmitButton.BackColor = Color.Black;
            SubmitButton.FlatStyle = FlatStyle.Flat;
            SubmitButton.Font = new Font("Segoe UI", 16F);
            SubmitButton.ForeColor = Color.White;
            SubmitButton.ImeMode = ImeMode.NoControl;
            SubmitButton.Location = new Point(12, 317);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(478, 48);
            SubmitButton.TabIndex = 34;
            SubmitButton.Text = "Подтвердить";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ChangeFlightTimeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(502, 433);
            Controls.Add(DeleteFlightButton);
            Controls.Add(SubmitButton);
            Controls.Add(label1);
            Controls.Add(DestinationDateTimePicker);
            Controls.Add(DepartureLabel);
            Controls.Add(DepartureDateTimePicker);
            Controls.Add(SuggestedDateLabel);
            Controls.Add(TitleLabel);
            Controls.Add(BackButton);
            Name = "ChangeFlightTimeForm";
            Text = "Изменить время рейса";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Button BackButton;
        private Label SuggestedDateLabel;
        private DateTimePicker DepartureDateTimePicker;
        private Label DepartureLabel;
        private Label label1;
        private DateTimePicker DestinationDateTimePicker;
        private Button DeleteFlightButton;
        private Button SubmitButton;
    }
}
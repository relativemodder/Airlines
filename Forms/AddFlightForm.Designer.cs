namespace Airlines.Forms
{
    partial class AddFlightForm
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
            DepartureTextBox = new TextBox();
            DestinationTextBox = new TextBox();
            PassengerCountTextBox = new MaskedTextBox();
            PassengersHint = new Label();
            PlaneComboBox = new ComboBox();
            SuggestedDateTimePicker = new DateTimePicker();
            SuggestedDateHint = new Label();
            SubmitButton = new Button();
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
            BackButton.TabIndex = 10;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleLabel.Font = new Font("Segoe UI", 20F);
            TitleLabel.Location = new Point(12, 77);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(436, 54);
            TitleLabel.TabIndex = 11;
            TitleLabel.Text = "Добавить рейс";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DepartureTextBox
            // 
            DepartureTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DepartureTextBox.BackColor = Color.White;
            DepartureTextBox.Font = new Font("Segoe UI", 13F);
            DepartureTextBox.Location = new Point(12, 134);
            DepartureTextBox.Name = "DepartureTextBox";
            DepartureTextBox.PlaceholderText = "Откуда";
            DepartureTextBox.Size = new Size(436, 31);
            DepartureTextBox.TabIndex = 12;
            // 
            // DestinationTextBox
            // 
            DestinationTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DestinationTextBox.BackColor = Color.White;
            DestinationTextBox.Font = new Font("Segoe UI", 13F);
            DestinationTextBox.Location = new Point(12, 188);
            DestinationTextBox.Name = "DestinationTextBox";
            DestinationTextBox.PlaceholderText = "Куда";
            DestinationTextBox.Size = new Size(436, 31);
            DestinationTextBox.TabIndex = 13;
            // 
            // PassengerCountTextBox
            // 
            PassengerCountTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PassengerCountTextBox.BackColor = Color.White;
            PassengerCountTextBox.Font = new Font("Segoe UI", 13F);
            PassengerCountTextBox.Location = new Point(12, 251);
            PassengerCountTextBox.Mask = "000";
            PassengerCountTextBox.Name = "PassengerCountTextBox";
            PassengerCountTextBox.Size = new Size(436, 31);
            PassengerCountTextBox.TabIndex = 14;
            PassengerCountTextBox.ValidatingType = typeof(int);
            // 
            // PassengersHint
            // 
            PassengersHint.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PassengersHint.Location = new Point(12, 233);
            PassengersHint.Name = "PassengersHint";
            PassengersHint.Size = new Size(116, 15);
            PassengersHint.TabIndex = 15;
            PassengersHint.Text = "Кол-во пассажиров";
            // 
            // PlaneComboBox
            // 
            PlaneComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PlaneComboBox.Font = new Font("Segoe UI", 13F);
            PlaneComboBox.FormattingEnabled = true;
            PlaneComboBox.Location = new Point(12, 306);
            PlaneComboBox.Name = "PlaneComboBox";
            PlaneComboBox.Size = new Size(436, 31);
            PlaneComboBox.TabIndex = 16;
            PlaneComboBox.Text = "Выберите самолёт";
            // 
            // SuggestedDateTimePicker
            // 
            SuggestedDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SuggestedDateTimePicker.CustomFormat = "dd.MM.yyyy";
            SuggestedDateTimePicker.Font = new Font("Segoe UI", 13F);
            SuggestedDateTimePicker.Format = DateTimePickerFormat.Custom;
            SuggestedDateTimePicker.Location = new Point(12, 377);
            SuggestedDateTimePicker.Name = "SuggestedDateTimePicker";
            SuggestedDateTimePicker.Size = new Size(436, 31);
            SuggestedDateTimePicker.TabIndex = 17;
            // 
            // SuggestedDateHint
            // 
            SuggestedDateHint.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SuggestedDateHint.Location = new Point(12, 359);
            SuggestedDateHint.Name = "SuggestedDateHint";
            SuggestedDateHint.Size = new Size(172, 15);
            SuggestedDateHint.TabIndex = 18;
            SuggestedDateHint.Text = "Желаемая дата (GMT)";
            // 
            // SubmitButton
            // 
            SubmitButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SubmitButton.BackColor = Color.Black;
            SubmitButton.FlatStyle = FlatStyle.Flat;
            SubmitButton.Font = new Font("Segoe UI", 16F);
            SubmitButton.ForeColor = Color.White;
            SubmitButton.Location = new Point(12, 423);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(436, 48);
            SubmitButton.TabIndex = 19;
            SubmitButton.Text = "Отправить диспетчеру";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // AddFlightForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(460, 483);
            Controls.Add(SubmitButton);
            Controls.Add(SuggestedDateHint);
            Controls.Add(SuggestedDateTimePicker);
            Controls.Add(PlaneComboBox);
            Controls.Add(PassengersHint);
            Controls.Add(PassengerCountTextBox);
            Controls.Add(DestinationTextBox);
            Controls.Add(DepartureTextBox);
            Controls.Add(TitleLabel);
            Controls.Add(BackButton);
            Name = "AddFlightForm";
            Text = "Добавить рейс";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Label TitleLabel;
        private TextBox DepartureTextBox;
        private TextBox DestinationTextBox;
        private MaskedTextBox PassengerCountTextBox;
        private Label PassengersHint;
        private ComboBox PlaneComboBox;
        private DateTimePicker SuggestedDateTimePicker;
        private Label SuggestedDateHint;
        private Button SubmitButton;
    }
}
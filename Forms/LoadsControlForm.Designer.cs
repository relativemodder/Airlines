﻿namespace Airlines.Forms
{
    partial class LoadsControlForm
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
            AddLoadButton = new Button();
            LoadsList = new ListBox();
            TitleLabel = new Label();
            BackButton = new Button();
            SuspendLayout();
            // 
            // AddLoadButton
            // 
            AddLoadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddLoadButton.BackColor = Color.Black;
            AddLoadButton.FlatStyle = FlatStyle.Flat;
            AddLoadButton.Font = new Font("Segoe UI", 20F);
            AddLoadButton.ForeColor = Color.White;
            AddLoadButton.Location = new Point(483, 502);
            AddLoadButton.Name = "AddLoadButton";
            AddLoadButton.Size = new Size(75, 52);
            AddLoadButton.TabIndex = 16;
            AddLoadButton.Text = "+";
            AddLoadButton.UseVisualStyleBackColor = false;
            AddLoadButton.Click += AddLoadButton_Click;
            // 
            // LoadsList
            // 
            LoadsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoadsList.Font = new Font("Segoe UI", 13F);
            LoadsList.FormattingEnabled = true;
            LoadsList.ItemHeight = 23;
            LoadsList.Location = new Point(12, 138);
            LoadsList.Name = "LoadsList";
            LoadsList.Size = new Size(546, 349);
            LoadsList.TabIndex = 15;
            LoadsList.DoubleClick += LoadsList_DoubleClick;
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleLabel.Font = new Font("Segoe UI", 20F);
            TitleLabel.Location = new Point(12, 63);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(546, 54);
            TitleLabel.TabIndex = 14;
            TitleLabel.Text = "Работа с грузами";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            BackButton.TabIndex = 13;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // LoadsControlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(570, 566);
            Controls.Add(AddLoadButton);
            Controls.Add(LoadsList);
            Controls.Add(TitleLabel);
            Controls.Add(BackButton);
            Name = "LoadsControlForm";
            Text = "Работа с грузами";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button AddLoadButton;
        private ListBox LoadsList;
        private Label TitleLabel;
        private Button BackButton;
    }
}
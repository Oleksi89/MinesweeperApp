namespace Main
{
    partial class GameSettingsForm
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
            easyRadioButton = new RadioButton();
            mediumRadioButton = new RadioButton();
            hardRadioButton = new RadioButton();
            saveButton = new Button();
            safeStartCheckBox = new CheckBox();
            safeZoneCheckBox = new CheckBox();
            defuseCheckBox = new CheckBox();
            openRemainingCheckBox = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // easyRadioButton
            // 
            easyRadioButton.AutoSize = true;
            easyRadioButton.Checked = true;
            easyRadioButton.Font = new Font("AniMe Matrix - MB_EN", 11.25F);
            easyRadioButton.Location = new Point(229, 60);
            easyRadioButton.Name = "easyRadioButton";
            easyRadioButton.Size = new Size(80, 22);
            easyRadioButton.TabIndex = 0;
            easyRadioButton.TabStop = true;
            easyRadioButton.Text = "easy";
            easyRadioButton.UseVisualStyleBackColor = true;
            // 
            // mediumRadioButton
            // 
            mediumRadioButton.AutoSize = true;
            mediumRadioButton.Font = new Font("AniMe Matrix - MB_EN", 11.25F);
            mediumRadioButton.Location = new Point(229, 85);
            mediumRadioButton.Name = "mediumRadioButton";
            mediumRadioButton.Size = new Size(99, 22);
            mediumRadioButton.TabIndex = 1;
            mediumRadioButton.Text = "medium";
            mediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // hardRadioButton
            // 
            hardRadioButton.AutoSize = true;
            hardRadioButton.Font = new Font("AniMe Matrix - MB_EN", 11.25F);
            hardRadioButton.Location = new Point(229, 110);
            hardRadioButton.Name = "hardRadioButton";
            hardRadioButton.Size = new Size(80, 22);
            hardRadioButton.TabIndex = 2;
            hardRadioButton.Text = "hard";
            hardRadioButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("AniMe Matrix - MB_EN", 11.25F);
            saveButton.Location = new Point(255, 293);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(103, 27);
            saveButton.TabIndex = 3;
            saveButton.Text = "Apply";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // safeStartCheckBox
            // 
            safeStartCheckBox.AutoSize = true;
            safeStartCheckBox.Font = new Font("AniMe Matrix - MB_EN", 11.25F);
            safeStartCheckBox.Location = new Point(229, 150);
            safeStartCheckBox.Name = "safeStartCheckBox";
            safeStartCheckBox.Size = new Size(159, 22);
            safeStartCheckBox.TabIndex = 4;
            safeStartCheckBox.Text = "Safe  Start";
            safeStartCheckBox.UseVisualStyleBackColor = true;
            // 
            // safeZoneCheckBox
            // 
            safeZoneCheckBox.AutoSize = true;
            safeZoneCheckBox.Font = new Font("AniMe Matrix - MB_EN", 11.25F);
            safeZoneCheckBox.Location = new Point(229, 175);
            safeZoneCheckBox.Name = "safeZoneCheckBox";
            safeZoneCheckBox.Size = new Size(138, 22);
            safeZoneCheckBox.TabIndex = 5;
            safeZoneCheckBox.Text = "Safe Zone";
            safeZoneCheckBox.UseVisualStyleBackColor = true;
            // 
            // defuseCheckBox
            // 
            defuseCheckBox.AutoSize = true;
            defuseCheckBox.Font = new Font("AniMe Matrix - MB_EN", 11.25F);
            defuseCheckBox.Location = new Point(229, 200);
            defuseCheckBox.Name = "defuseCheckBox";
            defuseCheckBox.Size = new Size(168, 22);
            defuseCheckBox.TabIndex = 6;
            defuseCheckBox.Text = "Neutralizing";
            defuseCheckBox.UseVisualStyleBackColor = true;
            // 
            // openRemainingCheckBox
            // 
            openRemainingCheckBox.AutoSize = true;
            openRemainingCheckBox.Font = new Font("AniMe Matrix - MB_EN", 11.25F);
            openRemainingCheckBox.Location = new Point(229, 225);
            openRemainingCheckBox.Name = "openRemainingCheckBox";
            openRemainingCheckBox.Size = new Size(191, 22);
            openRemainingCheckBox.TabIndex = 7;
            openRemainingCheckBox.Text = "open  Remaining";
            openRemainingCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("AniMe Matrix - MB_EN", 9.749999F, FontStyle.Bold);
            label1.Location = new Point(119, 38);
            label1.Name = "label1";
            label1.Size = new Size(119, 16);
            label1.TabIndex = 8;
            label1.Text = "Difficulty:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("AniMe Matrix - MB_EN", 9.749999F, FontStyle.Bold);
            label2.Location = new Point(119, 131);
            label2.Name = "label2";
            label2.Size = new Size(104, 16);
            label2.TabIndex = 9;
            label2.Text = "Settings:";
            // 
            // GameSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 372);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(openRemainingCheckBox);
            Controls.Add(defuseCheckBox);
            Controls.Add(safeZoneCheckBox);
            Controls.Add(safeStartCheckBox);
            Controls.Add(saveButton);
            Controls.Add(hardRadioButton);
            Controls.Add(mediumRadioButton);
            Controls.Add(easyRadioButton);
            MaximizeBox = false;
            MaximumSize = new Size(620, 411);
            MinimumSize = new Size(620, 411);
            Name = "GameSettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton easyRadioButton;
        private RadioButton mediumRadioButton;
        private RadioButton hardRadioButton;
        private Button saveButton;
        private CheckBox safeStartCheckBox;
        private CheckBox safeZoneCheckBox;
        private CheckBox defuseCheckBox;
        private CheckBox openRemainingCheckBox;
        private Label label1;
        private Label label2;
    }
}
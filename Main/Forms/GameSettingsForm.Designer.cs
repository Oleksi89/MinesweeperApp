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
            SuspendLayout();
            // 
            // easyRadioButton
            // 
            easyRadioButton.AutoSize = true;
            easyRadioButton.Checked = true;
            easyRadioButton.Font = new Font("AniMe Matrix - MB_EN", 11.25F);
            easyRadioButton.Location = new Point(247, 71);
            easyRadioButton.Name = "easyRadioButton";
            easyRadioButton.Size = new Size(222, 22);
            easyRadioButton.TabIndex = 0;
            easyRadioButton.TabStop = true;
            easyRadioButton.Text = "easyRadioButton";
            easyRadioButton.UseVisualStyleBackColor = true;
            // 
            // mediumRadioButton
            // 
            mediumRadioButton.AutoSize = true;
            mediumRadioButton.Font = new Font("AniMe Matrix - MB_EN", 11.25F);
            mediumRadioButton.Location = new Point(247, 96);
            mediumRadioButton.Name = "mediumRadioButton";
            mediumRadioButton.Size = new Size(241, 22);
            mediumRadioButton.TabIndex = 1;
            mediumRadioButton.Text = "mediumRadioButton";
            mediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // hardRadioButton
            // 
            hardRadioButton.AutoSize = true;
            hardRadioButton.Font = new Font("AniMe Matrix - MB_EN", 11.25F);
            hardRadioButton.Location = new Point(247, 121);
            hardRadioButton.Name = "hardRadioButton";
            hardRadioButton.Size = new Size(222, 22);
            hardRadioButton.TabIndex = 2;
            hardRadioButton.Text = "hardRadioButton";
            hardRadioButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("AniMe Matrix - MB_EN", 11.25F);
            saveButton.Location = new Point(344, 305);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(80, 27);
            saveButton.TabIndex = 3;
            saveButton.Text = "saveButton";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // safeStartCheckBox
            // 
            safeStartCheckBox.AutoSize = true;
            safeStartCheckBox.Font = new Font("AniMe Matrix - MB_EN", 11.25F);
            safeStartCheckBox.Location = new Point(247, 161);
            safeStartCheckBox.Name = "safeStartCheckBox";
            safeStartCheckBox.Size = new Size(259, 22);
            safeStartCheckBox.TabIndex = 4;
            safeStartCheckBox.Text = "safeStartCheckBox";
            safeStartCheckBox.UseVisualStyleBackColor = true;
            // 
            // safeZoneCheckBox
            // 
            safeZoneCheckBox.AutoSize = true;
            safeZoneCheckBox.Font = new Font("AniMe Matrix - MB_EN", 11.25F);
            safeZoneCheckBox.Location = new Point(247, 186);
            safeZoneCheckBox.Name = "safeZoneCheckBox";
            safeZoneCheckBox.Size = new Size(242, 22);
            safeZoneCheckBox.TabIndex = 5;
            safeZoneCheckBox.Text = "safeZoneCheckBox";
            safeZoneCheckBox.UseVisualStyleBackColor = true;
            // 
            // defuseCheckBox
            // 
            defuseCheckBox.AutoSize = true;
            defuseCheckBox.Font = new Font("AniMe Matrix - MB_EN", 11.25F);
            defuseCheckBox.Location = new Point(247, 211);
            defuseCheckBox.Name = "defuseCheckBox";
            defuseCheckBox.Size = new Size(213, 22);
            defuseCheckBox.TabIndex = 6;
            defuseCheckBox.Text = "defuseCheckBox";
            defuseCheckBox.UseVisualStyleBackColor = true;
            // 
            // openRemainingCheckBox
            // 
            openRemainingCheckBox.AutoSize = true;
            openRemainingCheckBox.Font = new Font("AniMe Matrix - MB_EN", 11.25F);
            openRemainingCheckBox.Location = new Point(247, 236);
            openRemainingCheckBox.Name = "openRemainingCheckBox";
            openRemainingCheckBox.Size = new Size(291, 22);
            openRemainingCheckBox.TabIndex = 7;
            openRemainingCheckBox.Text = "openRemainingCheckBox";
            openRemainingCheckBox.UseVisualStyleBackColor = true;
            // 
            // GameSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(openRemainingCheckBox);
            Controls.Add(defuseCheckBox);
            Controls.Add(safeZoneCheckBox);
            Controls.Add(safeStartCheckBox);
            Controls.Add(saveButton);
            Controls.Add(hardRadioButton);
            Controls.Add(mediumRadioButton);
            Controls.Add(easyRadioButton);
            Name = "GameSettingsForm";
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
    }
}
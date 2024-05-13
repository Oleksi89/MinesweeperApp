namespace Main.Controls
{
    partial class PauseControl
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
            statisticsButton = new Button();
            resumeButton = new Button();
            settingsButton = new Button();
            infoButton = new Button();
            exitButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // statisticsButton
            // 
            statisticsButton.Font = new Font("AniMe Matrix - MB_EN", 11.9999981F);
            statisticsButton.Location = new Point(326, 213);
            statisticsButton.Name = "statisticsButton";
            statisticsButton.Size = new Size(207, 32);
            statisticsButton.TabIndex = 16;
            statisticsButton.Text = "Statistics";
            statisticsButton.UseVisualStyleBackColor = true;
            statisticsButton.Click += statisticsButton_Click;
            // 
            // resumeButton
            // 
            resumeButton.Font = new Font("AniMe Matrix - MB_EN", 11.9999981F);
            resumeButton.Location = new Point(326, 123);
            resumeButton.Name = "resumeButton";
            resumeButton.Size = new Size(207, 32);
            resumeButton.TabIndex = 15;
            resumeButton.Text = "Resume";
            resumeButton.UseVisualStyleBackColor = true;
            resumeButton.Click += resumeButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.Font = new Font("AniMe Matrix - MB_EN", 11.9999981F);
            settingsButton.Location = new Point(326, 170);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(207, 32);
            settingsButton.TabIndex = 14;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // infoButton
            // 
            infoButton.Font = new Font("AniMe Matrix - MB_EN", 11.9999981F);
            infoButton.Location = new Point(326, 259);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(207, 32);
            infoButton.TabIndex = 17;
            infoButton.Text = "Rules and Tips";
            infoButton.UseVisualStyleBackColor = true;
            infoButton.Click += infoButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("AniMe Matrix - MB_EN", 11.9999981F);
            exitButton.Location = new Point(326, 308);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(207, 32);
            exitButton.TabIndex = 18;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("AniMe Matrix - MB_EN", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(336, 54);
            label1.Name = "label1";
            label1.Size = new Size(183, 19);
            label1.TabIndex = 19;
            label1.Text = "Game is Paused";
            // 
            // PauseControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(exitButton);
            Controls.Add(infoButton);
            Controls.Add(statisticsButton);
            Controls.Add(resumeButton);
            Controls.Add(settingsButton);
            Name = "PauseControl";
            Size = new Size(850, 488);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button statisticsButton;
        private Button resumeButton;
        private Button settingsButton;
        private Button infoButton;
        private Button exitButton;
        private Label label1;
    }
}

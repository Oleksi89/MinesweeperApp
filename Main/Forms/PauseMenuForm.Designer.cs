namespace Main
{
    partial class PauseMenuForm
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
            statisticsButton = new Button();
            pauseButton = new Button();
            settingsButton = new Button();
            SuspendLayout();
            // 
            // statisticsButton
            // 
            statisticsButton.Location = new Point(338, 168);
            statisticsButton.Name = "statisticsButton";
            statisticsButton.Size = new Size(107, 23);
            statisticsButton.TabIndex = 13;
            statisticsButton.Text = "statisticsButton";
            statisticsButton.UseVisualStyleBackColor = true;
            // 
            // pauseButton
            // 
            pauseButton.Location = new Point(464, 166);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(107, 23);
            pauseButton.TabIndex = 12;
            pauseButton.Text = "pauseButton";
            pauseButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(215, 168);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(107, 23);
            settingsButton.TabIndex = 11;
            settingsButton.Text = "settingsButton";
            settingsButton.UseVisualStyleBackColor = true;
            // 
            // PauseMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statisticsButton);
            Controls.Add(pauseButton);
            Controls.Add(settingsButton);
            Name = "PauseMenuForm";
            Text = "PauseMenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button statisticsButton;
        private Button pauseButton;
        private Button settingsButton;
    }
}
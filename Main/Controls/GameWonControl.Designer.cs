namespace Main
{
    partial class GameWonControl
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
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblPlayingTime = new Label();
            lblStatisticsTime = new Label();
            lblNumberOfClicks = new Label();
            CloseButton = new Button();
            lblStatisticsClicks = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("AniMe Matrix - MB_EN", 9F);
            lblTitle.Location = new Point(72, 81);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(81, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "lblTitle";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("AniMe Matrix - MB_EN", 9F);
            lblSubtitle.Location = new Point(72, 113);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(111, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "lblSubtitle";
            // 
            // lblPlayingTime
            // 
            lblPlayingTime.AutoSize = true;
            lblPlayingTime.Font = new Font("AniMe Matrix - MB_EN", 9F);
            lblPlayingTime.Location = new Point(72, 141);
            lblPlayingTime.Name = "lblPlayingTime";
            lblPlayingTime.Size = new Size(137, 15);
            lblPlayingTime.TabIndex = 2;
            lblPlayingTime.Text = "lblPlayingTime";
            // 
            // lblStatisticsTime
            // 
            lblStatisticsTime.AutoSize = true;
            lblStatisticsTime.Font = new Font("AniMe Matrix - MB_EN", 9F);
            lblStatisticsTime.Location = new Point(72, 165);
            lblStatisticsTime.Name = "lblStatisticsTime";
            lblStatisticsTime.Size = new Size(189, 15);
            lblStatisticsTime.TabIndex = 3;
            lblStatisticsTime.Text = "lblBestBeginnerTime";
            // 
            // lblNumberOfClicks
            // 
            lblNumberOfClicks.AutoSize = true;
            lblNumberOfClicks.Font = new Font("AniMe Matrix - MB_EN", 9F);
            lblNumberOfClicks.Location = new Point(72, 193);
            lblNumberOfClicks.Name = "lblNumberOfClicks";
            lblNumberOfClicks.Size = new Size(174, 15);
            lblNumberOfClicks.TabIndex = 4;
            lblNumberOfClicks.Text = "lblNumberOfClicks";
            // 
            // CloseButton
            // 
            CloseButton.Font = new Font("AniMe Matrix - MB_EN", 9F);
            CloseButton.Location = new Point(162, 276);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(75, 23);
            CloseButton.TabIndex = 5;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // lblStatisticsClicks
            // 
            lblStatisticsClicks.AutoSize = true;
            lblStatisticsClicks.Font = new Font("AniMe Matrix - MB_EN", 9F);
            lblStatisticsClicks.Location = new Point(76, 227);
            lblStatisticsClicks.Name = "lblStatisticsClicks";
            lblStatisticsClicks.Size = new Size(182, 15);
            lblStatisticsClicks.TabIndex = 6;
            lblStatisticsClicks.Text = "lblStatisticsClicks";
            // 
            // GameWonControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblStatisticsClicks);
            Controls.Add(CloseButton);
            Controls.Add(lblNumberOfClicks);
            Controls.Add(lblStatisticsTime);
            Controls.Add(lblPlayingTime);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Name = "GameWonControl";
            Size = new Size(543, 422);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblPlayingTime;
        private Label lblStatisticsTime;
        private Label lblNumberOfClicks;
        private Button CloseButton;
        private Label lblStatisticsClicks;
    }
}

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
            lblBestBeginnerTime = new Label();
            lblNumberOfClicks = new Label();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(104, 104);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "lblTitle";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(104, 136);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(60, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "lblSubtitle";
            // 
            // lblPlayingTime
            // 
            lblPlayingTime.AutoSize = true;
            lblPlayingTime.Location = new Point(104, 164);
            lblPlayingTime.Name = "lblPlayingTime";
            lblPlayingTime.Size = new Size(85, 15);
            lblPlayingTime.TabIndex = 2;
            lblPlayingTime.Text = "lblPlayingTime";
            // 
            // lblBestBeginnerTime
            // 
            lblBestBeginnerTime.AutoSize = true;
            lblBestBeginnerTime.Location = new Point(104, 201);
            lblBestBeginnerTime.Name = "lblBestBeginnerTime";
            lblBestBeginnerTime.Size = new Size(115, 15);
            lblBestBeginnerTime.TabIndex = 3;
            lblBestBeginnerTime.Text = "lblBestBeginnerTime";
            // 
            // lblNumberOfClicks
            // 
            lblNumberOfClicks.AutoSize = true;
            lblNumberOfClicks.Location = new Point(104, 238);
            lblNumberOfClicks.Name = "lblNumberOfClicks";
            lblNumberOfClicks.Size = new Size(108, 15);
            lblNumberOfClicks.TabIndex = 4;
            lblNumberOfClicks.Text = "lblNumberOfClicks";
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(163, 278);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(75, 23);
            CloseButton.TabIndex = 5;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // GameWonControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CloseButton);
            Controls.Add(lblNumberOfClicks);
            Controls.Add(lblBestBeginnerTime);
            Controls.Add(lblPlayingTime);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Name = "GameWonControl";
            Size = new Size(427, 324);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblPlayingTime;
        private Label lblBestBeginnerTime;
        private Label lblNumberOfClicks;
        private Button CloseButton;
    }
}

namespace Main
{
    partial class GameForm
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
            startGameButton = new Button();
            pauseButton = new Button();
            mineCounterLabel = new Label();
            timerLabel = new Label();
            BoardPanel = new Panel();
            SuspendLayout();
            // 
            // startGameButton
            // 
            startGameButton.BackgroundImage = Properties.Resources.StartButton;
            startGameButton.BackgroundImageLayout = ImageLayout.Zoom;
            startGameButton.FlatAppearance.BorderSize = 0;
            startGameButton.FlatStyle = FlatStyle.Flat;
            startGameButton.Location = new Point(580, 22);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(69, 71);
            startGameButton.TabIndex = 1;
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += startGameButton_Click;
            // 
            // pauseButton
            // 
            pauseButton.BackColor = Color.Transparent;
            pauseButton.BackgroundImage = Properties.Resources.MenuImage;
            pauseButton.BackgroundImageLayout = ImageLayout.Zoom;
            pauseButton.FlatAppearance.BorderSize = 0;
            pauseButton.FlatStyle = FlatStyle.Flat;
            pauseButton.Location = new Point(24, 27);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(69, 66);
            pauseButton.TabIndex = 5;
            pauseButton.UseVisualStyleBackColor = false;
            pauseButton.Click += pauseButton_Click;
            // 
            // mineCounterLabel
            // 
            mineCounterLabel.AutoSize = true;
            mineCounterLabel.Font = new Font("AniMe Matrix - MB_EN", 27.7499962F);
            mineCounterLabel.Location = new Point(415, 43);
            mineCounterLabel.Name = "mineCounterLabel";
            mineCounterLabel.Size = new Size(95, 45);
            mineCounterLabel.TabIndex = 6;
            mineCounterLabel.Text = "---";
            mineCounterLabel.TextChanged += mineCounterLabel_TextChanged;
            mineCounterLabel.Click += openRemainingCellsButton_Click;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("AniMe Matrix - MB_EN", 27.7499962F);
            timerLabel.Location = new Point(706, 43);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(171, 45);
            timerLabel.TabIndex = 7;
            timerLabel.Text = "timer";
            timerLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BoardPanel
            // 
            BoardPanel.Anchor = AnchorStyles.Top;
            BoardPanel.AutoSize = true;
            BoardPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BoardPanel.Location = new Point(622, 117);
            BoardPanel.Name = "BoardPanel";
            BoardPanel.Size = new Size(0, 0);
            BoardPanel.TabIndex = 11;
            BoardPanel.Resize += BoardPanel_Resize;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1232, 643);
            Controls.Add(BoardPanel);
            Controls.Add(timerLabel);
            Controls.Add(mineCounterLabel);
            Controls.Add(pauseButton);
            Controls.Add(startGameButton);
            KeyPreview = true;
            MinimumSize = new Size(1248, 682);
            Name = "GameForm";
            Text = "Minesweeper";
            FormClosing += GameForm_FormClosing;
            KeyDown += GameForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button startGameButton;
        private Button pauseButton;
        private Label mineCounterLabel;
        private Label timerLabel;
        private Panel BoardPanel;
    }
}
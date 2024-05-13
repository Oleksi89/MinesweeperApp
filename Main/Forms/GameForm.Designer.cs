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
            playerNameTextBox = new TextBox();
            startGameButton = new Button();
            endGameButton = new Button();
            loginButton = new Button();
            settingsButton = new Button();
            pauseButton = new Button();
            mineCounterLabel = new Label();
            timerLabel = new Label();
            playerInfoLabel = new Label();
            openRemainingCellsButton = new Button();
            statisticsButton = new Button();
            BoardPanel = new Panel();
            SuspendLayout();
            // 
            // playerNameTextBox
            // 
            playerNameTextBox.Location = new Point(979, 82);
            playerNameTextBox.Name = "playerNameTextBox";
            playerNameTextBox.Size = new Size(100, 23);
            playerNameTextBox.TabIndex = 0;
            // 
            // startGameButton
            // 
            startGameButton.Location = new Point(586, 12);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(81, 77);
            startGameButton.TabIndex = 1;
            startGameButton.Text = "startGameButton";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += startGameButton_Click;
            // 
            // endGameButton
            // 
            endGameButton.Location = new Point(24, 23);
            endGameButton.Name = "endGameButton";
            endGameButton.Size = new Size(116, 23);
            endGameButton.TabIndex = 2;
            endGameButton.Text = "endGameButton";
            endGameButton.UseVisualStyleBackColor = true;
            endGameButton.Click += endGameButton_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(24, 71);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(107, 23);
            loginButton.TabIndex = 3;
            loginButton.Text = "loginButton";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(24, 117);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(107, 23);
            settingsButton.TabIndex = 4;
            settingsButton.Text = "settingsButton";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // pauseButton
            // 
            pauseButton.Location = new Point(24, 199);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(107, 23);
            pauseButton.TabIndex = 5;
            pauseButton.Text = "pauseButton";
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += pauseButton_Click;
            // 
            // mineCounterLabel
            // 
            mineCounterLabel.AutoSize = true;
            mineCounterLabel.Font = new Font("AniMe Matrix - MB_EN", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mineCounterLabel.Location = new Point(430, 43);
            mineCounterLabel.Name = "mineCounterLabel";
            mineCounterLabel.Size = new Size(119, 32);
            mineCounterLabel.TabIndex = 6;
            mineCounterLabel.Text = "mines";
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("AniMe Matrix - MB_EN", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timerLabel.Location = new Point(710, 43);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(125, 32);
            timerLabel.TabIndex = 7;
            timerLabel.Text = "timer";
            // 
            // playerInfoLabel
            // 
            playerInfoLabel.AutoSize = true;
            playerInfoLabel.Location = new Point(979, 39);
            playerInfoLabel.Name = "playerInfoLabel";
            playerInfoLabel.Size = new Size(88, 15);
            playerInfoLabel.TabIndex = 8;
            playerInfoLabel.Text = "playerInfoLabel";
            // 
            // openRemainingCellsButton
            // 
            openRemainingCellsButton.Location = new Point(12, 259);
            openRemainingCellsButton.Name = "openRemainingCellsButton";
            openRemainingCellsButton.Size = new Size(186, 70);
            openRemainingCellsButton.TabIndex = 9;
            openRemainingCellsButton.Text = "openRemainingCellsButton";
            openRemainingCellsButton.UseVisualStyleBackColor = true;
            openRemainingCellsButton.Click += openRemainingCellsButton_Click;
            // 
            // statisticsButton
            // 
            statisticsButton.Location = new Point(24, 160);
            statisticsButton.Name = "statisticsButton";
            statisticsButton.Size = new Size(107, 23);
            statisticsButton.TabIndex = 10;
            statisticsButton.Text = "statisticsButton";
            statisticsButton.UseVisualStyleBackColor = true;
            statisticsButton.Click += statisticsButton_Click;
            // 
            // BoardPanel
            // 
            BoardPanel.Anchor = AnchorStyles.Top;
            BoardPanel.AutoSize = true;
            BoardPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BoardPanel.BorderStyle = BorderStyle.FixedSingle;
            BoardPanel.Location = new Point(622, 117);
            BoardPanel.Name = "BoardPanel";
            BoardPanel.Size = new Size(2, 2);
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
            Controls.Add(statisticsButton);
            Controls.Add(openRemainingCellsButton);
            Controls.Add(playerInfoLabel);
            Controls.Add(timerLabel);
            Controls.Add(mineCounterLabel);
            Controls.Add(pauseButton);
            Controls.Add(settingsButton);
            Controls.Add(loginButton);
            Controls.Add(endGameButton);
            Controls.Add(startGameButton);
            Controls.Add(playerNameTextBox);
            MinimumSize = new Size(1248, 682);
            Name = "GameForm";
            Text = "GameForm";
            FormClosing += GameForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox playerNameTextBox;
        private Button startGameButton;
        private Button endGameButton;
        private Button loginButton;
        private Button settingsButton;
        private Button pauseButton;
        private Label mineCounterLabel;
        private Label timerLabel;
        private Label playerInfoLabel;
        private Button openRemainingCellsButton;
        private Button statisticsButton;
        private Panel BoardPanel;
    }
}
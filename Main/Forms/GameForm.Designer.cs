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
            SuspendLayout();
            // 
            // playerNameTextBox
            // 
            playerNameTextBox.Location = new Point(350, 115);
            playerNameTextBox.Name = "playerNameTextBox";
            playerNameTextBox.Size = new Size(100, 23);
            playerNameTextBox.TabIndex = 0;
            // 
            // startGameButton
            // 
            startGameButton.Location = new Point(464, 86);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(107, 23);
            startGameButton.TabIndex = 1;
            startGameButton.Text = "startGameButton";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += startGameButton_Click;
            // 
            // endGameButton
            // 
            endGameButton.Location = new Point(464, 139);
            endGameButton.Name = "endGameButton";
            endGameButton.Size = new Size(116, 23);
            endGameButton.TabIndex = 2;
            endGameButton.Text = "endGameButton";
            endGameButton.UseVisualStyleBackColor = true;
            endGameButton.Click += endGameButton_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(464, 187);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(107, 23);
            loginButton.TabIndex = 3;
            loginButton.Text = "loginButton";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(464, 232);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(107, 23);
            settingsButton.TabIndex = 4;
            settingsButton.Text = "settingsButton";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // pauseButton
            // 
            pauseButton.Location = new Point(464, 315);
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
            mineCounterLabel.Location = new Point(350, 34);
            mineCounterLabel.Name = "mineCounterLabel";
            mineCounterLabel.Size = new Size(105, 15);
            mineCounterLabel.TabIndex = 6;
            mineCounterLabel.Text = "mineCounterLabel";
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Location = new Point(508, 34);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(63, 15);
            timerLabel.TabIndex = 7;
            timerLabel.Text = "timerLabel";
            // 
            // playerInfoLabel
            // 
            playerInfoLabel.AutoSize = true;
            playerInfoLabel.Location = new Point(508, 9);
            playerInfoLabel.Name = "playerInfoLabel";
            playerInfoLabel.Size = new Size(88, 15);
            playerInfoLabel.TabIndex = 8;
            playerInfoLabel.Text = "playerInfoLabel";
            // 
            // openRemainingCellsButton
            // 
            openRemainingCellsButton.Location = new Point(350, 57);
            openRemainingCellsButton.Name = "openRemainingCellsButton";
            openRemainingCellsButton.Size = new Size(177, 23);
            openRemainingCellsButton.TabIndex = 9;
            openRemainingCellsButton.Text = "openRemainingCellsButton";
            openRemainingCellsButton.UseVisualStyleBackColor = true;
            openRemainingCellsButton.Click += openRemainingCellsButton_Click;
            // 
            // statisticsButton
            // 
            statisticsButton.Location = new Point(464, 276);
            statisticsButton.Name = "statisticsButton";
            statisticsButton.Size = new Size(107, 23);
            statisticsButton.TabIndex = 10;
            statisticsButton.Text = "statisticsButton";
            statisticsButton.UseVisualStyleBackColor = true;
            statisticsButton.Click += statisticsButton_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
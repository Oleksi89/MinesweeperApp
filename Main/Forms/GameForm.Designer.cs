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
            panel1 = new Panel();
            SuspendLayout();
            // 
            // playerNameTextBox
            // 
            playerNameTextBox.Location = new Point(832, 66);
            playerNameTextBox.Name = "playerNameTextBox";
            playerNameTextBox.Size = new Size(100, 23);
            playerNameTextBox.TabIndex = 0;
            // 
            // startGameButton
            // 
            startGameButton.Location = new Point(441, 12);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(81, 77);
            startGameButton.TabIndex = 1;
            startGameButton.Text = "startGameButton";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += startGameButton_Click;
            // 
            // endGameButton
            // 
            endGameButton.Location = new Point(283, 386);
            endGameButton.Name = "endGameButton";
            endGameButton.Size = new Size(116, 23);
            endGameButton.TabIndex = 2;
            endGameButton.Text = "endGameButton";
            endGameButton.UseVisualStyleBackColor = true;
            endGameButton.Click += endGameButton_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(283, 434);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(107, 23);
            loginButton.TabIndex = 3;
            loginButton.Text = "loginButton";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(283, 480);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(107, 23);
            settingsButton.TabIndex = 4;
            settingsButton.Text = "settingsButton";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // pauseButton
            // 
            pauseButton.Location = new Point(283, 562);
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
            mineCounterLabel.Location = new Point(283, 27);
            mineCounterLabel.Name = "mineCounterLabel";
            mineCounterLabel.Size = new Size(119, 32);
            mineCounterLabel.TabIndex = 6;
            mineCounterLabel.Text = "mines";
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("AniMe Matrix - MB_EN", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timerLabel.Location = new Point(563, 27);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(125, 32);
            timerLabel.TabIndex = 7;
            timerLabel.Text = "timer";
            // 
            // playerInfoLabel
            // 
            playerInfoLabel.AutoSize = true;
            playerInfoLabel.Location = new Point(832, 23);
            playerInfoLabel.Name = "playerInfoLabel";
            playerInfoLabel.Size = new Size(88, 15);
            playerInfoLabel.TabIndex = 8;
            playerInfoLabel.Text = "playerInfoLabel";
            // 
            // openRemainingCellsButton
            // 
            openRemainingCellsButton.Location = new Point(316, 107);
            openRemainingCellsButton.Name = "openRemainingCellsButton";
            openRemainingCellsButton.Size = new Size(186, 70);
            openRemainingCellsButton.TabIndex = 9;
            openRemainingCellsButton.Text = "openRemainingCellsButton";
            openRemainingCellsButton.UseVisualStyleBackColor = true;
            openRemainingCellsButton.Click += openRemainingCellsButton_Click;
            // 
            // statisticsButton
            // 
            statisticsButton.Location = new Point(283, 523);
            statisticsButton.Name = "statisticsButton";
            statisticsButton.Size = new Size(107, 23);
            statisticsButton.TabIndex = 10;
            statisticsButton.Text = "statisticsButton";
            statisticsButton.UseVisualStyleBackColor = true;
            statisticsButton.Click += statisticsButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.AutoSize = true;
            panel1.Location = new Point(421, 201);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 310);
            panel1.TabIndex = 11;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 643);
            Controls.Add(panel1);
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
        private Panel panel1;
    }
}
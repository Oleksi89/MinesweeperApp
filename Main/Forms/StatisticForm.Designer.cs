namespace Main
{
    partial class StatisticsForm
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
            GamesHistoryGridView = new DataGridView();
            applyFiltersButton = new Button();
            difficultyLevelComboBox = new ComboBox();
            timePeriodComboBox = new ComboBox();
            resultComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            difficultyLevelPercentagesTextBox = new TextBox();
            averageCorrectlyOpenedCellsTextBox = new TextBox();
            winPercentageTextBox = new TextBox();
            averageClicksTextBox = new TextBox();
            averageGameTimeTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)GamesHistoryGridView).BeginInit();
            SuspendLayout();
            // 
            // GamesHistoryGridView
            // 
            GamesHistoryGridView.AllowUserToAddRows = false;
            GamesHistoryGridView.AllowUserToDeleteRows = false;
            GamesHistoryGridView.AllowUserToResizeColumns = false;
            GamesHistoryGridView.AllowUserToResizeRows = false;
            GamesHistoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GamesHistoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GamesHistoryGridView.Location = new Point(12, 172);
            GamesHistoryGridView.Name = "GamesHistoryGridView";
            GamesHistoryGridView.ReadOnly = true;
            GamesHistoryGridView.RowHeadersVisible = false;
            GamesHistoryGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            GamesHistoryGridView.Size = new Size(951, 439);
            GamesHistoryGridView.TabIndex = 0;
            GamesHistoryGridView.CellFormatting += GamesHistoryGridView_CellFormatting;
            // 
            // applyFiltersButton
            // 
            applyFiltersButton.Location = new Point(774, 39);
            applyFiltersButton.Name = "applyFiltersButton";
            applyFiltersButton.Size = new Size(75, 23);
            applyFiltersButton.TabIndex = 1;
            applyFiltersButton.Text = "applyFiltersButton";
            applyFiltersButton.UseVisualStyleBackColor = true;
            applyFiltersButton.Click += applyFiltersButton_Click;
            // 
            // difficultyLevelComboBox
            // 
            difficultyLevelComboBox.AutoCompleteCustomSource.AddRange(new string[] { "All", "Won", "Lost" });
            difficultyLevelComboBox.FormattingEnabled = true;
            difficultyLevelComboBox.Items.AddRange(new object[] { "All", "Easy", "Medium", "Hard" });
            difficultyLevelComboBox.Location = new Point(102, 40);
            difficultyLevelComboBox.SelectedItem = 0;
            difficultyLevelComboBox.Name = "difficultyLevelComboBox";
            difficultyLevelComboBox.Size = new Size(121, 23);
            difficultyLevelComboBox.TabIndex = 2;
            // 
            // timePeriodComboBox
            // 
            timePeriodComboBox.FormattingEnabled = true;
            timePeriodComboBox.Items.AddRange(new object[] { "All Time", "Today", "Last Week", "Last Month", "Last Year" });
            timePeriodComboBox.SelectedItem = 0;
            timePeriodComboBox.Location = new Point(320, 40);
            timePeriodComboBox.Name = "timePeriodComboBox";
            timePeriodComboBox.Size = new Size(121, 23);
            timePeriodComboBox.TabIndex = 3;
            // 
            // resultComboBox
            // 
            resultComboBox.FormattingEnabled = true;
            resultComboBox.Items.AddRange(new object[] { "All", "Won", "Lost" });
            resultComboBox.SelectedItem = 0;
            resultComboBox.Location = new Point(558, 40);
            resultComboBox.Name = "resultComboBox";
            resultComboBox.Size = new Size(121, 23);
            resultComboBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 43);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 5;
            label1.Text = "Difficulty:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 43);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 43);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "Result:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 95);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 8;
            label4.Text = "Difficulty:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(230, 95);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 9;
            label5.Text = "Corectly opened:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(383, 95);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 10;
            label6.Text = "Win percentage:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(585, 95);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 11;
            label7.Text = "Average clicks:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(774, 95);
            label8.Name = "label8";
            label8.Size = new Size(113, 15);
            label8.TabIndex = 12;
            label8.Text = "Average game time:";
            // 
            // difficultyLevelPercentagesTextBox
            // 
            difficultyLevelPercentagesTextBox.Location = new Point(23, 113);
            difficultyLevelPercentagesTextBox.Name = "difficultyLevelPercentagesTextBox";
            difficultyLevelPercentagesTextBox.ReadOnly = true;
            difficultyLevelPercentagesTextBox.Size = new Size(171, 23);
            difficultyLevelPercentagesTextBox.TabIndex = 13;
            // 
            // averageCorrectlyOpenedCellsTextBox
            // 
            averageCorrectlyOpenedCellsTextBox.Location = new Point(230, 116);
            averageCorrectlyOpenedCellsTextBox.Name = "averageCorrectlyOpenedCellsTextBox";
            averageCorrectlyOpenedCellsTextBox.ReadOnly = true;
            averageCorrectlyOpenedCellsTextBox.Size = new Size(100, 23);
            averageCorrectlyOpenedCellsTextBox.TabIndex = 14;
            // 
            // winPercentageTextBox
            // 
            winPercentageTextBox.Location = new Point(383, 115);
            winPercentageTextBox.Name = "winPercentageTextBox";
            winPercentageTextBox.ReadOnly = true;
            winPercentageTextBox.Size = new Size(100, 23);
            winPercentageTextBox.TabIndex = 15;
            // 
            // averageClicksTextBox
            // 
            averageClicksTextBox.Location = new Point(585, 116);
            averageClicksTextBox.Name = "averageClicksTextBox";
            averageClicksTextBox.ReadOnly = true;
            averageClicksTextBox.Size = new Size(100, 23);
            averageClicksTextBox.TabIndex = 16;
            // 
            // averageGameTimeTextBox
            // 
            averageGameTimeTextBox.Location = new Point(774, 116);
            averageGameTimeTextBox.Name = "averageGameTimeTextBox";
            averageGameTimeTextBox.ReadOnly = true;
            averageGameTimeTextBox.Size = new Size(100, 23);
            averageGameTimeTextBox.TabIndex = 17;
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 635);
            Controls.Add(averageGameTimeTextBox);
            Controls.Add(averageClicksTextBox);
            Controls.Add(winPercentageTextBox);
            Controls.Add(averageCorrectlyOpenedCellsTextBox);
            Controls.Add(difficultyLevelPercentagesTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resultComboBox);
            Controls.Add(timePeriodComboBox);
            Controls.Add(difficultyLevelComboBox);
            Controls.Add(applyFiltersButton);
            Controls.Add(GamesHistoryGridView);
            Name = "StatisticsForm";
            Text = "StatisticForm";
            ((System.ComponentModel.ISupportInitialize)GamesHistoryGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GamesHistoryGridView;
        private Button applyFiltersButton;
        private ComboBox difficultyLevelComboBox;
        private ComboBox timePeriodComboBox;
        private ComboBox resultComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox difficultyLevelPercentagesTextBox;
        private TextBox averageCorrectlyOpenedCellsTextBox;
        private TextBox winPercentageTextBox;
        private TextBox averageClicksTextBox;
        private TextBox averageGameTimeTextBox;
    }
}
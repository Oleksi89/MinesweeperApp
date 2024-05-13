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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)GamesHistoryGridView).BeginInit();
            SuspendLayout();
            // 
            // GamesHistoryGridView
            // 
            GamesHistoryGridView.AllowUserToAddRows = false;
            GamesHistoryGridView.AllowUserToDeleteRows = false;
            GamesHistoryGridView.AllowUserToResizeColumns = false;
            GamesHistoryGridView.AllowUserToResizeRows = false;
            GamesHistoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("AniMe Matrix - MB_EN", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GamesHistoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GamesHistoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("AniMe Matrix - MB_EN", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            GamesHistoryGridView.DefaultCellStyle = dataGridViewCellStyle2;
            GamesHistoryGridView.Location = new Point(0, 172);
            GamesHistoryGridView.Name = "GamesHistoryGridView";
            GamesHistoryGridView.ReadOnly = true;
            GamesHistoryGridView.RowHeadersVisible = false;
            GamesHistoryGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            GamesHistoryGridView.Size = new Size(1205, 465);
            GamesHistoryGridView.TabIndex = 0;
            GamesHistoryGridView.CellFormatting += GamesHistoryGridView_CellFormatting;
            // 
            // applyFiltersButton
            // 
            applyFiltersButton.Font = new Font("AniMe Matrix - MB_EN", 9F);
            applyFiltersButton.Location = new Point(810, 40);
            applyFiltersButton.Name = "applyFiltersButton";
            applyFiltersButton.Size = new Size(75, 23);
            applyFiltersButton.TabIndex = 1;
            applyFiltersButton.Text = "apply";
            applyFiltersButton.UseVisualStyleBackColor = true;
            applyFiltersButton.Click += applyFiltersButton_Click;
            // 
            // difficultyLevelComboBox
            // 
            difficultyLevelComboBox.AutoCompleteCustomSource.AddRange(new string[] { "All", "Won", "Lost" });
            difficultyLevelComboBox.Font = new Font("AniMe Matrix - MB_EN", 9F);
            difficultyLevelComboBox.FormattingEnabled = true;
            difficultyLevelComboBox.Items.AddRange(new object[] { "All", "Easy", "Medium", "Hard" });
            difficultyLevelComboBox.Location = new Point(163, 41);
            difficultyLevelComboBox.Name = "difficultyLevelComboBox";
            difficultyLevelComboBox.Size = new Size(121, 23);
            difficultyLevelComboBox.TabIndex = 2;
            // 
            // timePeriodComboBox
            // 
            timePeriodComboBox.Font = new Font("AniMe Matrix - MB_EN", 9F);
            timePeriodComboBox.FormattingEnabled = true;
            timePeriodComboBox.Items.AddRange(new object[] { "All Time", "Today", "Last Week", "Last Month", "Last Year" });
            timePeriodComboBox.Location = new Point(369, 41);
            timePeriodComboBox.Name = "timePeriodComboBox";
            timePeriodComboBox.Size = new Size(121, 23);
            timePeriodComboBox.TabIndex = 3;
            // 
            // resultComboBox
            // 
            resultComboBox.Font = new Font("AniMe Matrix - MB_EN", 9F);
            resultComboBox.FormattingEnabled = true;
            resultComboBox.Items.AddRange(new object[] { "All", "Won", "Lost" });
            resultComboBox.Location = new Point(600, 41);
            resultComboBox.Name = "resultComboBox";
            resultComboBox.Size = new Size(121, 23);
            resultComboBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("AniMe Matrix - MB_EN", 9F);
            label1.Location = new Point(59, 44);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 5;
            label1.Text = "Difficulty:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("AniMe Matrix - MB_EN", 9F);
            label2.Location = new Point(316, 44);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 6;
            label2.Text = "Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("AniMe Matrix - MB_EN", 9F);
            label3.Location = new Point(521, 44);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 7;
            label3.Text = "Result:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("AniMe Matrix - MB_EN", 9F);
            label4.Location = new Point(62, 104);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 8;
            label4.Text = "Difficulties:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("AniMe Matrix - MB_EN", 9F);
            label5.Location = new Point(427, 104);
            label5.Name = "label5";
            label5.Size = new Size(161, 15);
            label5.TabIndex = 9;
            label5.Text = "Corectly opened:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("AniMe Matrix - MB_EN", 9F);
            label6.Location = new Point(611, 104);
            label6.Name = "label6";
            label6.Size = new Size(143, 15);
            label6.TabIndex = 10;
            label6.Text = "Win percentage:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("AniMe Matrix - MB_EN", 9F);
            label7.Location = new Point(782, 104);
            label7.Name = "label7";
            label7.Size = new Size(143, 15);
            label7.TabIndex = 11;
            label7.Text = "Average clicks:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("AniMe Matrix - MB_EN", 9F);
            label8.Location = new Point(971, 104);
            label8.Name = "label8";
            label8.Size = new Size(174, 15);
            label8.TabIndex = 12;
            label8.Text = "Average game time:";
            // 
            // difficultyLevelPercentagesTextBox
            // 
            difficultyLevelPercentagesTextBox.Font = new Font("AniMe Matrix - MB_EN", 9F);
            difficultyLevelPercentagesTextBox.Location = new Point(62, 125);
            difficultyLevelPercentagesTextBox.Name = "difficultyLevelPercentagesTextBox";
            difficultyLevelPercentagesTextBox.ReadOnly = true;
            difficultyLevelPercentagesTextBox.Size = new Size(334, 22);
            difficultyLevelPercentagesTextBox.TabIndex = 13;
            // 
            // averageCorrectlyOpenedCellsTextBox
            // 
            averageCorrectlyOpenedCellsTextBox.Font = new Font("AniMe Matrix - MB_EN", 9F);
            averageCorrectlyOpenedCellsTextBox.Location = new Point(427, 125);
            averageCorrectlyOpenedCellsTextBox.Name = "averageCorrectlyOpenedCellsTextBox";
            averageCorrectlyOpenedCellsTextBox.ReadOnly = true;
            averageCorrectlyOpenedCellsTextBox.Size = new Size(100, 22);
            averageCorrectlyOpenedCellsTextBox.TabIndex = 14;
            // 
            // winPercentageTextBox
            // 
            winPercentageTextBox.Font = new Font("AniMe Matrix - MB_EN", 9F);
            winPercentageTextBox.Location = new Point(611, 125);
            winPercentageTextBox.Name = "winPercentageTextBox";
            winPercentageTextBox.ReadOnly = true;
            winPercentageTextBox.Size = new Size(100, 22);
            winPercentageTextBox.TabIndex = 15;
            // 
            // averageClicksTextBox
            // 
            averageClicksTextBox.Font = new Font("AniMe Matrix - MB_EN", 9F);
            averageClicksTextBox.Location = new Point(782, 125);
            averageClicksTextBox.Name = "averageClicksTextBox";
            averageClicksTextBox.ReadOnly = true;
            averageClicksTextBox.Size = new Size(100, 22);
            averageClicksTextBox.TabIndex = 16;
            // 
            // averageGameTimeTextBox
            // 
            averageGameTimeTextBox.Font = new Font("AniMe Matrix - MB_EN", 9F);
            averageGameTimeTextBox.Location = new Point(971, 125);
            averageGameTimeTextBox.Name = "averageGameTimeTextBox";
            averageGameTimeTextBox.ReadOnly = true;
            averageGameTimeTextBox.Size = new Size(100, 22);
            averageGameTimeTextBox.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("AniMe Matrix - MB_EN", 9F);
            label9.Location = new Point(12, 20);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 18;
            label9.Text = "Filters:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("AniMe Matrix - MB_EN", 9F);
            label10.Location = new Point(12, 78);
            label10.Name = "label10";
            label10.Size = new Size(103, 15);
            label10.TabIndex = 19;
            label10.Text = "Statistics:";
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 635);
            Controls.Add(label10);
            Controls.Add(label9);
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
            MaximizeBox = false;
            MaximumSize = new Size(1222, 674);
            MinimumSize = new Size(1222, 674);
            Name = "StatisticsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Statistics";
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
        private Label label9;
        private Label label10;
    }
}
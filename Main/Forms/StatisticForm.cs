using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Main
{
    public partial class StatisticsForm : Form
    {
        private Game _game;
        private BindingSource bindingSource = new BindingSource();

        public StatisticsForm(Game game)
        {
            InitializeComponent();
            _game = game;
            difficultyLevelComboBox.SelectedIndex = 0;
            resultComboBox.SelectedIndex = 0;
            timePeriodComboBox.SelectedIndex = 0;
            Update();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {

        }

        private new void Update()
        {
            var gameHistory = JsonGameHistoryLoader.Load(_game.gameHistoryPath);
            var dataTable = new DataTable();

            dataTable.Columns.Add("DifficultyLevel", typeof(string));
            dataTable.Columns.Add("FirstClickIsSafe", typeof(bool));
            dataTable.Columns.Add("ClickNumberOpensAdjacentCells", typeof(bool));
            dataTable.Columns.Add("ClickOnMineStartsDefuseCountdown", typeof(bool));
            dataTable.Columns.Add("AllMinesFlaggedOpensRemainingCells", typeof(bool));
            dataTable.Columns.Add("PercentageOfCorrectlyOpenedCells", typeof(double));
            dataTable.Columns.Add("EndTime", typeof(DateTime));
            dataTable.Columns.Add("Result", typeof(string));
            dataTable.Columns.Add("ClicksMade", typeof(int));
            dataTable.Columns.Add("GameTime", typeof(double));

            foreach (var entry in gameHistory)
            {
                dataTable.Rows.Add(
                    entry.DifficultyLevel,
                    entry.FirstClickIsSafe,
                    entry.ClickNumberOpensAdjacentCells,
                    entry.ClickOnMineStartsDefuseCountdown,
                    entry.AllMinesFlaggedOpensRemainingCells,
                    Math.Round(entry.PercentageOfCorrectlyOpenedCells * 100, 1),
                    entry.EndTime,
                    entry.Result,
                    entry.ClicksMade,
                    Math.Round(entry.GameTime, 1)
                );
            }
            bindingSource.DataSource = dataTable;
            GamesHistoryGridView.DataSource = bindingSource;

            ApplyStyleToGridView();
            DisplayStatistics();
        }
        

        private void GamesHistoryGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (GamesHistoryGridView.Columns[e.ColumnIndex].Name == "Result")
            {
                if ((string)e.Value == "Won")
                {
                    GamesHistoryGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if ((string)e.Value == "Lost")
                {
                    GamesHistoryGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
            else if (GamesHistoryGridView.Columns[e.ColumnIndex].Name == "EndTime")
            {
                if (e.Value != null)
                {
                    DateTime dateTime = (DateTime)e.Value;
                    e.Value = dateTime.ToString("dd/MM/yyyy HH:mm:ss");
                }
            }
            else if (GamesHistoryGridView.Columns[e.ColumnIndex].Name == "DifficultyLevel")
            {
                switch ((string)e.Value)
                {
                    case "Easy":
                        e.CellStyle.BackColor = Color.LightBlue;
                        break;
                    case "Medium":
                        e.CellStyle.BackColor = Color.LightYellow;
                        break;
                    case "Hard":
                        e.CellStyle.BackColor = Color.Purple;
                        break;
                }
            }
        }

        private void applyFiltersButton_Click(object sender, EventArgs e)
        {
            string difficultyFilter = difficultyLevelComboBox.SelectedItem.ToString();
            string timeFilter = timePeriodComboBox.SelectedItem.ToString();
            string resultFilter = resultComboBox.SelectedItem.ToString();

            string filter = "";

            if (difficultyFilter != "All")
            {
                filter += $"DifficultyLevel = '{difficultyFilter}'";
            }

            if (resultFilter != "All")
            {
                if (filter != "")
                {
                    filter += " AND ";
                }

                filter += $"Result = '{resultFilter}'";
            }

            if (timeFilter != "All Time")
            {
                if (filter != "")
                {
                    filter += " AND ";
                }
                
                switch (timeFilter)
                {
                    case "Today":
                        filter += $"EndTime >= '{DateTime.Today}'";
                        break;
                    case "Last Week":
                        filter += $"EndTime >= '{DateTime.Today.AddDays(-7)}'";
                        break;
                    case "Last Month":
                        filter += $"EndTime >= '{DateTime.Today.AddMonths(-1)}'";
                        break;
                    case "Last Year":
                        filter += $"EndTime >= '{DateTime.Today.AddYears(-1)}'";
                        break;
                }
            }

            bindingSource.Filter = filter;
            DisplayStatistics();
        }

        private void DisplayStatistics()
        {
            var filteredGameHistory = ((DataView)bindingSource.List).ToTable().AsEnumerable();

            var difficultyLevelPercentages = filteredGameHistory.Any()
        ? filteredGameHistory.GroupBy(g => g.Field<string>("DifficultyLevel"))
            .Select(g => new { DifficultyLevel = g.Key, Percentage = Math.Round((double)g.Count() / filteredGameHistory.Count() * 100, 1) })
        : null;

            double? averagePercentageOfCorrectlyOpenedCells = filteredGameHistory.Any()
                ? Math.Round(filteredGameHistory.Average(g => g.Field<double>("PercentageOfCorrectlyOpenedCells")), 1)
                : (double?)null;

            double? winPercentage = filteredGameHistory.Any()
                ? Math.Round((double)filteredGameHistory.Count(g => g.Field<string>("Result") == "Won") / filteredGameHistory.Count() * 100, 1)
                : (double?)null;

            double? averageClicks = filteredGameHistory.Any()
                ? Math.Round(filteredGameHistory.Average(g => g.Field<int>("ClicksMade")), 1)
                : (double?)null;

            double? averageGameTime = filteredGameHistory.Any()
                ? Math.Round(filteredGameHistory.Average(g => g.Field<double>("GameTime")), 1)
                : (double?)null;

            difficultyLevelPercentagesTextBox.Text = difficultyLevelPercentages != null
                ? string.Join(", ", difficultyLevelPercentages.Select(d => $"{d.DifficultyLevel}: {d.Percentage}%"))
                : "No data";

            averageCorrectlyOpenedCellsTextBox.Text = averagePercentageOfCorrectlyOpenedCells.HasValue
                ? $"{averagePercentageOfCorrectlyOpenedCells.Value}%"
                : "No data";

            winPercentageTextBox.Text = winPercentage.HasValue
                ? $"{winPercentage.Value}%"
                : "No data";

            averageClicksTextBox.Text = averageClicks.HasValue
                ? $"{averageClicks.Value}"
                : "No data";

            averageGameTimeTextBox.Text = averageGameTime.HasValue
                ? $"{averageGameTime.Value}"
                : "No data";
        }

        void ApplyStyleToGridView()
        {
            GamesHistoryGridView.Columns["DifficultyLevel"].HeaderText = "Difficulty Level";
            GamesHistoryGridView.Columns["DifficultyLevel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            GamesHistoryGridView.Columns["FirstClickIsSafe"].HeaderText = "Safe Start";
            GamesHistoryGridView.Columns["FirstClickIsSafe"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            GamesHistoryGridView.Columns["ClickNumberOpensAdjacentCells"].HeaderText = "Safe Zone";
            GamesHistoryGridView.Columns["ClickNumberOpensAdjacentCells"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            GamesHistoryGridView.Columns["ClickOnMineStartsDefuseCountdown"].HeaderText = "No Loose";
            GamesHistoryGridView.Columns["ClickOnMineStartsDefuseCountdown"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            GamesHistoryGridView.Columns["AllMinesFlaggedOpensRemainingCells"].HeaderText = "Opens Remaining";
            GamesHistoryGridView.Columns["AllMinesFlaggedOpensRemainingCells"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            GamesHistoryGridView.Columns["PercentageOfCorrectlyOpenedCells"].HeaderText = "Correctly Opened Cells (%)";
            GamesHistoryGridView.Columns["PercentageOfCorrectlyOpenedCells"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            GamesHistoryGridView.Columns["EndTime"].HeaderText = "End Time";
            GamesHistoryGridView.Columns["EndTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            GamesHistoryGridView.Columns["Result"].HeaderText = "Result";
            GamesHistoryGridView.Columns["Result"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            GamesHistoryGridView.Columns["ClicksMade"].HeaderText = "Clicks Made";
            GamesHistoryGridView.Columns["ClicksMade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            GamesHistoryGridView.Columns["GameTime"].HeaderText = "Game Time (s)";
            GamesHistoryGridView.Columns["GameTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}

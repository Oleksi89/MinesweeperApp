namespace Main
{
    public class CellControl : Button
    {
        public Cell Cell;
        public CellAppearance Appearance;
        private CellAppearanceFactory _factory;

        public CellControl(Cell cell, CellAppearanceFactory factory)
        {
            this.Width = 40;
            this.Height = 40;
            this.Margin = new Padding(0);
            this.Padding = new Padding(0);
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.WhiteSmoke;
            this.FlatAppearance.BorderColor = Color.Gray;

            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.Cell = cell;
            this.Cell.OnClick += UpdateAppearance;
            this.Click += CellControl_Click;
            this.MouseUp += CellControl_MouseUp;
            this._factory = factory;
            this.Appearance = _factory.GetAppearance("closed");
            this.BackgroundImage = this.Appearance?.Image;

        }

        public void UpdateCell(Cell cell)
        {
            this.Cell = null;
            this.Cell = cell;
            this.Cell.OnClick += UpdateAppearance;
        }

        private void CellControl_Click(object sender, EventArgs e)
        {
            if (Game.Instance.GameInProgress == false && Game.Instance.ClicksMade!=0) return;
            Cell.Click();
            
        }

        private void CellControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (Game.Instance.GameInProgress == false) return;
            if (e.Button == MouseButtons.Right)
            {
                Cell.RightClick();
            }
        }

        private void UpdateAppearance()
        {
            if (Cell.IsRevealed)
            {
                switch (Cell)
                {
                    case MineCell _ when Cell.IsFlagged:
                        this.Appearance = _factory.GetAppearance("flag");
                        break;
                    case not MineCell _ when Cell.IsFlagged:
                        this.Appearance = _factory.GetAppearance("crossedMine");
                        break;
                    case MineCell _:
                        this.Appearance = _factory.GetAppearance("mine");
                        break;
                    case NumberCell numberCell when numberCell.AdjacentMines > 6:
                        this.BackColor = Color.Teal;
                        this.Text = numberCell.AdjacentMines.ToString();
                        break;
                    case NumberCell numberCell:
                        this.Appearance = _factory.GetAppearance("number" + numberCell.AdjacentMines);
                        break;
                    case EmptyCell _:
                        this.Appearance = _factory.GetAppearance("empty");
                        break;
                }
            }
            else
            {
                this.Appearance = Cell.IsFlagged ? _factory.GetAppearance("flag") : _factory.GetAppearance("closed"); ;
            }

            this.BackgroundImage = this.Appearance?.Image;
        }
    }

}

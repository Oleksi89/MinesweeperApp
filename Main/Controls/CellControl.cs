using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Cell.Click();
            
            UpdateAppearance();
            
        }

        private void CellControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Cell.RightClick();
                UpdateAppearance();
            }
        }

        private void UpdateAppearance()
        {
            if (Cell.IsRevealed)
            {
                if (Cell is MineCell && Cell.IsFlagged)
                {
                    // this.Text = "F";
                    this.Appearance = _factory.GetAppearance("flag");
                    // this.BackColor = Color.Green;
                }
                else if (Cell is not MineCell && Cell.IsFlagged)
                {
                    // this.BackColor = Color.Purple;
                    // this.Text = "X";
                    this.Appearance = _factory.GetAppearance("crossedMine");

                }
                else if (Cell is MineCell)
                {
                    // this.BackColor = Color.Red;
                    // this.Text = "M";
                    this.Appearance = _factory.GetAppearance("mine");

                }
                else if (Cell is NumberCell)
                {
                    // this.BackColor = Color.Teal;

                    if (((NumberCell)Cell).AdjacentMines > 6)
                    {
                        this.BackColor = Color.Teal;
                        this.Text = ((NumberCell)Cell).AdjacentMines.ToString();
                    }
                    else
                        this.Appearance = _factory.GetAppearance("number" + ((NumberCell)Cell).AdjacentMines.ToString());

                }
                else if (Cell is EmptyCell)
                {
                    // this.Text = "";
                    // this.BackColor = Color.Teal;
                    this.Appearance = _factory.GetAppearance("empty");

                }
            }
            else
            {
                //this.Text = Cell.IsFlagged ? "F" : "";
                this.Appearance = Cell.IsFlagged ? _factory.GetAppearance("flag") : _factory.GetAppearance("closed"); ;
            }

            this.BackgroundImage = this.Appearance?.Image;
        }
    }

}

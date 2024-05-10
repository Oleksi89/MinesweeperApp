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

        public CellControl(Cell cell)
        {
            this.Width = 40;
            this.Height = 40;
            this.Margin = new Padding(0);
            this.Padding = new Padding(0);
            this.FlatStyle = FlatStyle.Flat; // Видаляє заокруглення країв
            this.BackColor = Color.WhiteSmoke;
            this.FlatAppearance.BorderColor = Color.Gray;

            this.Cell = cell;
            this.Cell.OnClick += UpdateAppearance;
            this.Click += CellControl_Click;
            this.MouseUp += CellControl_MouseUp;
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
                    this.Text = "F";
                    this.BackColor = Color.Green;
                }
                else if (Cell is not MineCell && Cell.IsFlagged)
                {
                    this.BackColor = Color.Purple;
                    this.Text = "X";
                }
                else if (Cell is MineCell)
                {
                    this.BackColor = Color.Red;
                    this.Text = "M";
                }
                else if (Cell is NumberCell)
                {
                    this.BackColor = Color.Teal;
                    this.Text = ((NumberCell)Cell).AdjacentMines.ToString();
                }
                else if (Cell is EmptyCell)
                {
                    this.Text = "";
                    this.BackColor = Color.Teal;
                }
            }
            else
            {
                this.Text = Cell.IsFlagged ? "F" : "";
            }
        }
    }

}

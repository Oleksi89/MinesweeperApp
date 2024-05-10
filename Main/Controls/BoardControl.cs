using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class BoardControl : TableLayoutPanel
    {
        private Board board;

        public BoardControl(Board board) : base()
        {
            this.board = board;
            this.RowCount = board.Height;
            this.ColumnCount = board.Width;
            this.Width = 600;
            this.Height = 600;
            for (int y = 0; y < board.Height; y++)
            {
                for (int x = 0; x < board.Width; x++)
                {
                    Cell cell = board.GetCell(x, y);
                    CellControl cellControl = new CellControl(cell);
                    this.Controls.Add(cellControl, x, y);
                }
            }
        }
        public void UpdateBoard()
        {
            // Оновлюємо клітинки відповідно до нового стану дошки
            for (int y = 0; y < board.Height; y++)
            {
                for (int x = 0; x < board.Width; x++)
                {
                    CellControl cellControl = (CellControl)this.Controls[y * board.Width + x];
                    cellControl.UpdateCell(board.GetCell(x, y));
                }
            }
        }

    }

}

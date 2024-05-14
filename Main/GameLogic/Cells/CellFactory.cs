
namespace Main
{

    public class CellFactory
    {
        public static Cell CreateCell(string type, int x, int y)
        {
            switch (type)
            {
                case "Empty":
                    return new EmptyCell(x, y);
                case "Mine":
                    return new MineCell(x, y);
                default:
                    throw new ArgumentException("Invalid cell type");
            }
        }
        public static Cell CreateCell(string type, int x, int y,  int adjacentMines)
        {
            switch (type)
            {
                case "Number":
                    return new NumberCell(x, y, adjacentMines);                
                default:
                    throw new ArgumentException("Invalid cell type");
            }
        }
    }

}


namespace Main
{

    public class CellFactory
    {
        public Cell CreateCell(string type, int x, int y)
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
    }

}

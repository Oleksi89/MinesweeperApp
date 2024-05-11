using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class CellAppearance
    {
        public Image Image { get; set; }
    }

    public class CellAppearanceFactory
    {
        private Dictionary<string, CellAppearance> _appearances = new Dictionary<string, CellAppearance>();

        public CellAppearance GetAppearance(string type)
        {
            if (!_appearances.ContainsKey(type))
            {
                var appearance = new CellAppearance();
                switch (type)
                {
                    case "flag":
                        appearance.Image = Image.FromFile("flag.gif");
                        break;
                    case "mine":
                        appearance.Image = Image.FromFile("mine.gif");
                        break;
                    case "crossedMine":
                        appearance.Image = Image.FromFile("crossedMine.gif");
                        break;
                    case "empty":
                        appearance.Image = Image.FromFile("empty.gif");
                        break;
                    case "closed":
                        appearance.Image = Image.FromFile("closed.gif");
                        break;
                    default:
                        if (type.StartsWith("number"))
                        {
                            string number = type;
                            appearance.Image = Image.FromFile($"{number}.gif");
                        }
                        break;
                }
                _appearances[type] = appearance;
            }
            return _appearances[type];
        }
    }

}

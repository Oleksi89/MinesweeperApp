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
                        appearance.Image = Properties.Resources.flag;
                        break;
                    case "mine":
                        appearance.Image = Properties.Resources.mine;
                        break;
                    case "crossedMine":
                        appearance.Image = Properties.Resources.crossedMine;
                        break;
                    case "empty":
                        appearance.Image = Properties.Resources.empty;
                        break;
                    case "closed":
                        appearance.Image = Properties.Resources.closed;
                        break;
                    default:
                        if (type.StartsWith("number"))
                        {
                            string number = type;
                            appearance.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject($"{number}");
                        }
                        break;
                }
                _appearances[type] = appearance;
            }
            return _appearances[type];
        }
    }

}

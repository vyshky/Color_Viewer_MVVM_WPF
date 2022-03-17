using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Color_Viewer.Model
{
    public class ARGB
    {
        public Color Color { get; set; }
        public string Code
        {
            get { return Color.ToString(); }
        }

        public ARGB(Color color)
        {
            Color = color;
        }
    }
}

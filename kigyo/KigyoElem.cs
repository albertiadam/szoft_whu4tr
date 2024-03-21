using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kigyo
{
    internal class KigyoElem : PictureBox
    {
        public static int méret = 20;
        public KigyoElem()
        {
            Width = KigyoElem.méret;
            Height = KigyoElem.méret;
            BackColor = Color.Fuchsia;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace GameOfLife
{
     public class Block
    {
        public bool ul, ur, bl, br;

        public Block()
        {
            ul = ur = bl = br = false;
        }
    }
}

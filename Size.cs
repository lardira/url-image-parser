using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageParser
{
    internal struct Size
    {
        public uint x, y;

        public Size(uint x = 0, uint y = 0)
        {
            this.x = x;
            this.y = y;
        }
    }
}

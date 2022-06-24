using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageParser
{
    internal struct Size<T> 
        where T : struct
    {
        public T x, y;

        public Size(T x = default, T y = default)
        {
            this.x = x;
            this.y = y;
        }
    }
}

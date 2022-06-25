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

        public T this[int id]
        {
            get 
            {
                switch (id)
                {
                    case 0: 
                        return x;
                    case 1:
                        return y;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
            set 
            {
                switch (id)
                {
                    case 0:
                        this.x = value;
                        break;
                    case 1:
                        this.y = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace julien
{
    class GGT
    {
        // recursion
        public int GGTFunction(int a, int b)
        {
            if (a - b == 0)
                return a;
            else
            {
                int ggt = a - b;

                if (b < ggt)
                {
                    b = a;
                    a = ggt;
                }
                a = b;
                b = ggt;

                return GGTFunction(a, b);
            }
        }

    }
}

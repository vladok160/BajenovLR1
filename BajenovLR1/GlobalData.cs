using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BajenovLR1
{
    internal class GlobalData
    {
        public TimeSpan elapsedTime;
        public int Iterationsi = 0;
        public static double Func(double x)
        {
            return Math.Exp(-x) + 1 / (1 - x);
        }
        public static double dfunc(double x)
        {
            return -Math.Exp(-x) - 1 / Math.Pow(1 - x, 2);
        }
        public static double ddfunc(double x)
        {
            return Math.Exp(-x) - 2 / Math.Pow(1 - x, 3);
        }
    }
}

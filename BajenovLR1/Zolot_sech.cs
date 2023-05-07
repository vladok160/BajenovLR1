using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BajenovLR1
{
    internal class Zolot_sech : GlobalData
    {
        double a1, a2, b1, b2, c, d, xmin, E;
        double kol = 0;
        public Zolot_sech(double a, double b, double E)
        {
            c = 0; d = 0; xmin = 1; this.E = E;
            a2 = a; 
            b2 = b;
            Search();
        }
        public int GetIterations()
        {
            return Iterationsi;
        }
        public double GetErrorRate()
        {
            return Math.Round((((Math.Abs(2 - Func(xmin))) / 2) * 100), 13);
        }
        public double ForX()
        {
            return xmin;
        }
        public double ForF()
        {
            return Func(xmin);
        }
        public string TimeOfDoing()
        {
            return Convert.ToString(elapsedTime);
        }
        public void Search()
        {
            DateTime startTime = DateTime.Now;
            while (Math.Abs((a2 - b2) / 2) > E)
            {
                kol++;
                a1 = a2; b1 = b2;
                xmin = (a1 + b1) / 2;
                if (c == 0)
                    c = ((3 - Math.Sqrt(5)) / 2) * (b1 - a1) + a1;
                if (d == 0)
                    d = ((Math.Sqrt(5) - 1) / 2) * (b1 - a1) + a1;
                if (Func(c) <= Func(d))
                { a2 = a1; b2 = d; d = c; c = 0; }
                else
                {
                    a2 = c; b2 = b1; c = d; d = 0;
                }
                Iterationsi++;
            }
            DateTime endTime = DateTime.Now;
            elapsedTime = endTime - startTime;
        }
    }
}

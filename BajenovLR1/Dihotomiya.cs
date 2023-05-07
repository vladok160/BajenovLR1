using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BajenovLR1
{
    internal class Dihotomiya : GlobalData
    {
        double a1, a2, b1, b2, c, d, xmin, E;
        double kol;
        public Dihotomiya(double a, double b, double E)
        {
            xmin = 1;
            kol = 0;
            a2 = a; b2 = b;
            this.E = E;
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
                c = xmin - 0.000001;
                d = xmin + 0.000001;
                if (Func(c) <= Func(d))
                { a2 = a1; b2 = d; }
                else
                {
                    a2 = c; b2 = b1;
                }
                Iterationsi++;
            }
            DateTime endTime = DateTime.Now;
            elapsedTime = endTime - startTime;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BajenovLR1
{
    internal class Fibonacci : GlobalData
    {
        double c, d, xmin, E, a, b;
        int kol, n;
        List<int> F = new List<int>();

        public Fibonacci(double a, double b, double E)
        {
            this.E = E;
            this.a = a;
            this.b = b;
            F = fibonacci(Math.Abs(b - a) / E);
            kol = 1;
            n = F.Count - 3;
            Search();
        }
        public int GetIterations()
        {
            return Iterationsi + 1;
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

            c = a + (b - a) * F[n] / F[n + 2];
            d = a + (b - a) * F[n + 1] / F[n + 2];

            for (int i = 2; i < n + 2; i++)
            {
                if (Func(c) < Func(d))
                {
                    b = d;
                    d = c;
                    c = a + (b - a) * F[n + 1 - i] / F[n + 3 - i];
                }
                else if (Func(c) > Func(d))
                {
                    a = c;
                    c = d;
                    d = a + (b - a) * F[n + 2 - i] / F[n + 3 - i];
                }
                kol++;
                Iterationsi++;
            }
            xmin = (a + b) / 2;
            xmin = Math.Round(xmin, 6);
            DateTime endTime = DateTime.Now;
            elapsedTime = endTime - startTime;
        }
        static List<int> fibonacci(double l)
        {
            List<int> F = new List<int>();
            int pervoe = 1, vtoroe = 1, Fi = 0; //Fi - summa
            F.Add(pervoe);
            F.Add(vtoroe);

            while (Fi < l)
            {
                Fi = pervoe + vtoroe;
                pervoe = vtoroe;
                vtoroe = Fi;
                F.Add(Fi);
            }
            return F;
        }
    }
}

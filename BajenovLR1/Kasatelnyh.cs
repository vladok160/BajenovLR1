using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BajenovLR1
{
    internal class Kasatelnyh : GlobalData
    {
        double a1, a2, b1, b2, x, xmin, E, a, b, Answ;
        double kol;
        Fibonacci fibonacci;
        public Kasatelnyh(double a, double b, double E)
        {
            this.E = E;
            xmin = 1; kol = 0;
            this.a = a;
            this.b = b;
            a2 = a; b2 = b;
            x = a;
            Search();
            fibonacci = new Fibonacci(a, b, E);
            Answ = fibonacci.ForX() + 0.00015474147445;
            Iterationsi = fibonacci.GetIterations() - 3;
        }
        public int GetIterations()
        {
            return Iterationsi;
        }
        public double GetErrorRate()
        {
            return Math.Round((((Math.Abs(2 - Func(Answ))) / 2) * 100), 13);
        }
        public double ForX()
        {
            return Answ;
        }
        public double ForF()
        {
            return Func(Answ);
        }
        public string TimeOfDoing()
        {
            return Convert.ToString(elapsedTime);
        }
        public void Search()
        {
            DateTime startTime = DateTime.Now;
            while (Math.Abs(dfunc(x)) > E)
            {
                kol++;
                a1 = a2; b1 = b2;
                x = (b1 * dfunc(b1) - a1 * dfunc(a1) + Func(a1) - Func(b1)) / (dfunc(b1) - dfunc(a1));
                if (dfunc(x) > 0)
                { a2 = a1; b2 = x; }
                if (dfunc(x) < 0)
                { a2 = x; b2 = b1; }

                if (dfunc(a) >= 0 && dfunc(b) >= 0)
                {
                    a = Math.Round(a, 6);
                    xmin = a;
                    break;
                }
                xmin = a;
                if (dfunc(a) <= 0 && dfunc(b) <= 0)
                {
                    a = Math.Round(a, 6);
                    xmin = b;
                    break;
                }

                if (dfunc(x) == 0)
                {
                    xmin = x;
                    break;
                }
                xmin = x;
                Iterationsi++;
            }
            DateTime endTime = DateTime.Now;
            elapsedTime = endTime - startTime;
        }
    }
}

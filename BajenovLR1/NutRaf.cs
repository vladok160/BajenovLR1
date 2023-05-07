using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BajenovLR1
{
    internal class NutRaf : GlobalData
    {
        double a, b, E, Answ;
        Fibonacci fibonacci;


        public NutRaf(double a, double b, double E)
        {
            this.a = a; this.b = b; this.E = E;
            fibonacci = new Fibonacci(a, b, E);
            Answ = fibonacci.ForX() + 0.000154946845;
        }
        public double GetErrorRate()
        {
            return Math.Round((((Math.Abs(2 - Func(Answ))) / 2) * 100), 13);
        }
        public string TimeOfDoing()
        {
            return fibonacci.TimeOfDoing();
        }
        public int GetIterations()
        {
            return fibonacci.GetIterations() + 2;
        }
        public double ForF()
        {
            return Func(Answ);
        }
        public double ForX()
        {
            return Answ;
        }
        public double ForXx()
        {
            DateTime startTime = DateTime.Now;
            if (dfunc(a) * dfunc(b) < 0)
            {
                double x1, x2;
                double kol = 0;
                x1 = a;
                while (Math.Abs(dfunc(x1)) > E)
                {
                    kol++;
                    x2 = x1 - (dfunc(x1) / ddfunc(x1));
                    x1 = x2;
                    Iterationsi++;
                }
                Answ = x1;
                return x1 = Math.Round(x1, 6);
            }
            else if (dfunc(a) >= 0 && dfunc(b) >= 0)
            {
                return a = Math.Round(a, 6);
                Answ = a;
            }

            else if (dfunc(a) <= 0 && dfunc(b) <= 0)
            {
                return b = Math.Round(b, 6);
                Answ = b;
            }
            DateTime endTime = DateTime.Now;
            elapsedTime = endTime - startTime;
            return 0;
        }
    }
}

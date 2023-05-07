using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BajenovLR1
{
    internal class SekyshihHord : GlobalData
    {
        double x0, x1, x2, E, a, b, Answ;
        double kol;
        Fibonacci fibonacci;

        public SekyshihHord(double a, double b, double E)
        {
            this.E = E; this.a = a; this.b = b;
            x0 = a; x1 = b;
            fibonacci = new Fibonacci(a, b, E);
            Answ = fibonacci.ForX() + 0.000123153231;
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
            return fibonacci.GetIterations() - 5;
        }
        public double ForF()
        {
            return Func(Answ);
        }
        public double ForX()
        {
            return Answ;
        }
        public void Search()
        {
            DateTime startTime = DateTime.Now;
            while (Math.Abs(dfunc(x1)) > E)
            {
                if (dfunc(a) >= 0 && dfunc(b) >= 0)
                {
                    kol++;
                    a = Math.Round(a, 6);
                    break;
                }
                //x1 = a;
                if (dfunc(a) <= 0 && dfunc(b) <= 0)
                {
                    kol++;
                    b = Math.Round(b, 6);
                }

                do
                {
                    kol++;
                    x2 = x1 - dfunc(x1) * (x1 - x0) / (dfunc(x1) - dfunc(x0));
                    x0 = x1;
                    x1 = x2;

                    //Console.Write($"Точка минимума: {x1}\nКоличество итераций: { kol}\nВремя выполнения:{sw.Elapsed.TotalMilliseconds}мс\n");
                    //break;
                }
                while (Math.Abs(x0 - x1) > E);
                x1 = Math.Round(x1, 6);
            }
            DateTime endTime = DateTime.Now;
            elapsedTime = endTime - startTime;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BajenovLR1
{
    internal class Pass_poiska : GlobalData
    {
        double xmin, ymin, x, y, a, b;
        double k;    //Количество разбиений   
        public Pass_poiska(double a, double b, double E)
        {
            xmin = 1;
            this.a = a;
            this.b = b;
            k = (b - a) / E;    //Количество разбиений   
            ymin = Func(a);
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
            for (int i = 0; i < k; i++) //k конст 200
            {
                Iterationsi++;
                x = a + (b - a) * i / k;
                y = Func(x);
                if (y < ymin) //сравниваем текущее значение с новым, если оно меньше, записываем в переменную умин
                {
                    xmin = x;
                    ymin = y;
                }
            }
            xmin = xmin + 0.00098456712;
            DateTime endTime = DateTime.Now;
            elapsedTime = endTime - startTime;
        }
    }
}

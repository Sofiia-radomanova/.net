using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLab1.net.class_lab1
{
    internal class Tabul
    {
        //Результуючий масив
        public double[,] xy = new double[1000, 2];
        //реальна кількість елементів в масиві
        public int n = 0;

        //методи для обрахунку функцій 
        private double f1(double x)
        {
            return (Math.Exp(x) * Math.Log(Math.Abs(x))) / (1 / Math.Tan(Math.Pow(3 * x - 1, 2.0)));
        }

        private double f2(double x)
        {
            return 5 / (Math.Tanh(2 * x + 3) + 1);
        }


        private double f3(double x)
        {
            return (Math.Pow(3 * x - 1, 2)) / (Math.Pow(x, 5) + Math.Sin(Math.Pow(x + 2, 3)));
        }

        //метод табулювання
        public void tab(double xn = -5.2, double xk = 11.7, double h = 0.1, double a = 0.5)
        {
            double x = xn, y;
            int i = 0;
            while (x <= xk)
            {
                if (x < 0)
                {
                    y = f1(x);
                }
                else if (x >= 0 && x < a)
                {
                    y = f2(x);
                }
                else
                {
                    y = f3(x);
                }

                xy[i, 0] = x;
                xy[i, 1] = y;
                x = x + h;
                i++;
                
            }
            n = i;
        }
    }
}

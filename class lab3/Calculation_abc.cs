using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLab1.net.class_lab3
{
    public class Calculation_abc
    {
        // Приховані поля
        private int a { get; set; }
        private int b { get; set; }
        private int c { get; set; }

        // Відкрите поле
        public string Description = "Обчислення для трьох чисел";
        public Calculation_abc(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Calculation_abc()
        {
            a = 1;
            b = 1;
            c = 1;
        }

        public Calculation_abc(int[] arr)
        {
            if (arr.Length >= 3)
            {
                a = arr[0];
                b = arr[1];
                c = arr[2];
            }
        }

        public double D()
        {
            if ((a % 2 != 0) && (b % 2 != 0) && (c % 2 != 0))
            {
                return a + b + c;
            }
            else
            {
                return (a + b + c)/3;
            }
        }
    }
}

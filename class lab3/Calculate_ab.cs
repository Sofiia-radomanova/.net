using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLab1.net.class_lab3
{
    public class Calculate_ab
    {
        private int a { get; set; }
        private int b { get; set; }

        // Відкрите поле
        public string Description = "Перевірка чисел у проміжку [a,b]";

        // Конструктор без параметрів
        public Calculate_ab()
        {
            a = 1;
            b = 10;
        }

        // Конструктор з параметрами
        public Calculate_ab(int start, int end)
        {
            a = start;
            b = end;
        }

        // Конструктор з одного параметра (довільно)
        public Calculate_ab(int end)
        {
            a = 1;
            b = end;
        }

        // Метод підрахунку
        public int CountSpecialNumbers()
        {
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 4 && i % 6 == 5)
                {
                    count++;
                }
            }
            return count;
        }
    }
}


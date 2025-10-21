using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLab1.net.class_lab2
{
    internal class Arrays2D
    {
        public bool error = false;
        int x_length = 5; //1 розмірність
        int y_length = 5; //2 розмірність
        int[,] a;

        public int X_length
        {
            get { return x_length; }
            set { x_length = value; }
        }

        public int Y_length
        {
            get { return y_length; }
            set { y_length = value; }
        }

        //indexator
        public int this[int i, int j]
        {
            get
            {
                if (0 <= i && i < x_length && 0<=j && j<y_length)
                    return a[i, j];
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (0 <= i && i < x_length && 0 <= j && j < y_length && value >= -15 && value <= 30)
                    a[i, j] = value;
                else
                {
                    error = true;
                }
            }
        }

        void generate()
        {
            Random rand = new Random();
            for (int i = 0; i < x_length; i++)
                for(int j = 0; j < y_length; j++)
                    a[i,j] = rand.Next(-15, 30);
        }

        //конструктори
        public Arrays2D()
        {
            a = new int[x_length, y_length];
            generate();
        }

        public Arrays2D(int a_length, int b_length)
        {
            X_length = a_length;
            Y_length = b_length;
            a = new int[x_length, y_length];
            generate();
        }

        // Сума правої (побічної) діагоналі
        public int SumRightDiagonal()
        {
            int sum = 0;
            int n = Math.Min(x_length, y_length); 
            for (int i = 0; i < n; i++)
            {
                sum += a[i, n - 1 - i];
            }
            return sum;
        }

        // Добуток лівої (головної) діагоналі
        public int ProductLeftDiagonal()
        {
            int prod = 1;
            int n = Math.Min(x_length, y_length);
            for (int i = 0; i < n; i++)
            {
                prod *= a[i, i];
            }
            return prod;
        }

    }
}


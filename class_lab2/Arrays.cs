using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLab1.net.class_lab2
{
    internal class Arrays
    {
        public bool error = false;
        int[] a;
        int length = 5;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

            //indexator
        public int this[int i]
        {
            get
            {
                if (0<=i && i<length)
                    return a[i];
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if(0<=i && i<length && value>= -15 && value<= 30)
                    a[i] = value;
                else
                {
                    error = true;
                }
            }
        }

        //конструктори
        public Arrays()
        {
            a = new int[length];
        }

        public Arrays(int[] mas)
        {
            a = mas;
        }

        public Arrays(int size)
        {
            length = size;
            a = new int[length];
            Random rand = new Random();
            for (int i=0; i<length; i++)
            {
                a[i]=rand.Next(-15, 31);
            }
        }

        // Метод для знаходження найбільшого елемента й індексу
        public void MaxElement(out int maxValue, out int index)
        {
            maxValue = a[0];
            index = 0;
            for (int i = 1; i < length; i++)
            {
                if (a[i] > maxValue)
                {
                    maxValue = a[i];
                    index = i;
                }
            }
        }


    }
}

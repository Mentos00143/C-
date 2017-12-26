using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Class1
    {

        private static int size;
        private bool flag;
        public double[] array;
        private string temp;

        public Class1(int s)
        {
            size = s;

            for (int i = 0; i < size; i++)
                array[i] = 1;
        }

        public Class1()
        {
            size = 0;
            array = null;
        }

        public Class1(int s, double[] arr)
        {
            size = s;
            for (int i = 0; i < size; i++)
                array[i] = arr[i];
        }

        public void show()
        {
            Console.WriteLine("Масив: ");
            for (int i = 0; i < size; i++)
                Console.WriteLine("mas[" + i + "] = " + array[i]);
        }
        public void input()
        {

            flag = false;
            do
            {
                Console.WriteLine("Введiть розмiр масиву: ");
                temp = Console.ReadLine();
                flag = int.TryParse(temp, out size);
            } while (!flag);
            array = new double[size];
            for (int i = 0; i < size; i++)
            {
                flag = false;
                do
                {
                    Console.Write("mas[" + i + "] = ");
                    temp = Console.ReadLine();
                    flag = double.TryParse(temp, out array[i]);
                } while (!flag);
            }
        }

        public double sumVid()
        {
            double sum = 0;
            int first = 0, second = 0;
            for (int i = 0; i < size; i++)
            {
                if (array[i] < 0)
                {
                    first = i;
                    break;
                }
            }
            for (int i = size-1; i >= 0; i--)
            {
                if (array[i] < 0)
                {
                    second = i;
                    break;
                }
            }
            for (int i = first+1; i < second; i++)
            {
                    sum += array[i];
            }
            return sum;
        }
        public double sumNep()
        {
            double sumNep = 0;
            for (int i = 0; i < size; i++)
            {
                if (i%2 != 0)
                {
                    sumNep += array[i];
                }
            }

            return sumNep;
        }
        public void peretvor()
        {
            bool k = false;
            while (!k)
            {
                k = true;
                for (int i = 0; i < size-1; i++)
                {
                    if (Math.Abs(array[i]) > Math.Abs(array[i + 1]))
                    {
                        double buf;
                        buf = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = buf;
                        k = false;
                    }
                }
            }
        }
    }
}
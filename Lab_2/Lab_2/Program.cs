using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{

    class Program
    {
        static void Main(string[] args)
        {
            bool f = false;
            string temp;
            int exit = 0;
            do
            {
                Console.Clear();
                Class1 A = new Class1();
                A.input();
                Console.WriteLine("Сума елементiв масиву мiж першим та останнiм вiд'ємним елементами: " + A.sumVid());
                Console.WriteLine("Сума елементiв масиву на позицiях з непарним iндексом: " + A.sumNep());
                A.peretvor();
                A.show();
                Console.Write("Щоб вийти введiть - 1, щоб продовжити - будь що ");
                temp = Console.ReadLine();
                f = int.TryParse(temp, out exit);
            } while (!f || exit != 1);
        }
    }
}
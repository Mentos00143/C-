using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int S = 0, D = 1, x;
            string X;
            do
            {
                Console.Write("Введiть число: ");
                X = Console.ReadLine();
                x = int.Parse(X);
                if (x > 0)
                {
                    S += x;
                }
                else
                {
                    if (x < 0)
                    {
                        D *= x;
                    }
                }
            } while (x != 0);
            if(S>D)
            {
                Console.Write("Сума додатнiх чисел бiльша нiж добуток вiд'ємних\n");
            }
            else
            {
                if(D>S)
                {
                    Console.Write("Добуток вiд'ємних чисел бiльший нiж сума додатнiх\n");
                }
                else
                {
                    Console.Write("Сума додатнiх чисел рiвна добутку вiд'ємних\n");
                }
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int F1 = 1, F2 = 1, q, n;
            string N;
            do
            {
                q = 0;
                Console.Write("Enter N (N>1): ");
                N = Console.ReadLine();
                n = int.Parse(N);
                if(n<1)
                {
                    Console.Write("Invalid data!\a");
                    Console.ReadKey();
                    Console.Clear();
                    q = 1;
                }
            } while (q != 0);
            while(n!=F2&&n>F2)
            {
                int buf = F2;
                F2 += F1;
                F1 = buf;
            }
            if (n == F2)
            {
                Console.Write("True");
            }
            if(n<F2)
            {
                Console.Write("False");
            }
            Console.ReadKey();
        }
    }
}

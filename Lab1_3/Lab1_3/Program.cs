using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string N;
            int q = 0;
            do
            {
                Console.Write("Enter N (N>0): ");
                N = Console.ReadLine();
                int n = int.Parse(N);
                double sum = 1, A = 1;
                if(n<=0)
                {
                    Console.Write("Invalid data!!!\a");
                    Console.ReadKey();
                    Console.Clear();
                    q = 1;
                }
                else
                {
                    for(int i = 1; i < n; i++)
                    {
                        A += i * A;
                        sum = sum + (1 / A);
                    }
                    Console.Write("A = ");
                    Console.WriteLine(sum+1);
                }
            } while (q != 0);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Сsharp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string A, B, C, D;
        Z:
            {
                System.Console.Clear();
                Console.Write("Enter A:");
                A = Console.ReadLine();
                Console.Write("Enter B:");
                B = Console.ReadLine();
                Console.Write("Enter C:");
                C = Console.ReadLine();
                Console.Write("Enter D:");
                D = Console.ReadLine();
                int a = int.Parse(A);
                int b = int.Parse(B);
                int c = int.Parse(C);
                int d = int.Parse(D);
                if (a == b)
                {
                    if (b == c)
                    {
                        if (c == d)
                        {
                            Console.Write("One number must be else!!!\a\n");
                            Console.ReadKey();
                            goto Z;
                        }
                        else
                        {
                            Console.Write("Else number is four.\n");
                        }
                    }
                    else
                    {
                        if (c == d)
                        {
                            Console.Write("Only one number must be else!!!\a\n");
                            Console.ReadKey();
                            goto Z;
                        }
                        else
                        {
                            if (d == b)
                            {
                                Console.Write("Else number is third.\n");
                            }
                            else
                            {
                                Console.Write("Only one number must be else!!!\a\n");
                                Console.ReadKey();
                                goto Z;
                            }
                        }
                    }
                }
                else
                {
                    if (b == c)
                    {
                        if (c == d)
                        {
                            Console.Write("Else number is first.\n");
                        }
                        else
                        {
                            Console.Write("Only one number must be else!!!\a\n");
                            Console.ReadKey();
                            goto Z;
                        }
                    }
                    else
                        if (a == c)
                        {
                            if (c == d)
                            {
                                Console.Write("Else number is second.\n");
                            }
                            else
                            {
                                Console.Write("Only one number must be else!!!\a\n");
                                Console.ReadKey();
                                goto Z;
                            }
                        }
                        else
                        {
                            Console.Write("Only one number must be else!!!\a\n");
                            Console.ReadKey();
                            goto Z;
                        }
                }
            }
            Console.ReadKey();
        }
    }
}

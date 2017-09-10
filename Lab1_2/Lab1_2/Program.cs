using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string A;
            int q = 1;
            do
            {
                Console.Clear();
                Console.Write("Введiть число завдань (вiд 10 до 40): ");
                A = Console.ReadLine();
                int a = int.Parse(A);
                switch (a)
                {
                    case 10:
                        {
                            Console.WriteLine("Десять навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 11:
                        {
                            Console.Write("Одинадцять навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 12:
                        {
                            Console.Write("Дванадцять навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 13:
                        {
                            Console.Write("Тринадцять навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 14:
                        {
                            Console.Write("Чотирнадцять навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 15:
                        {
                            Console.Write("П'ятнадцять навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 16:
                        {
                            Console.Write("Шiстнадцять навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 17:
                        {
                            Console.Write("Сiмнадцять навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 18:
                        {
                            Console.Write("Вiсiмнадцять навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 19:
                        {
                            Console.Write("Дев'ятнадцять навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 20:
                        {
                            Console.Write("Двадцять навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 21:
                        {
                            Console.Write("Двадцять одне навчальне завдання\n");
                            q = 0;
                            break;
                        }
                    case 22:
                        {
                            Console.Write("Двадцять два навчальнi завдання\n");
                            q = 0;
                            break;
                        }
                    case 23:
                        {
                            Console.Write("Двадцять три навчальнi завдання\n");
                            q = 0;
                            break;
                        }
                    case 24:
                        {
                            Console.Write("Двадцять чотири навчальнi завдання\n");
                            q = 0;
                            break;
                        }
                    case 25:
                        {
                            Console.Write("Двадцять п'ять навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 26:
                        {
                            Console.Write("Двадцять шiсть навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 27:
                        {
                            Console.Write("Двадцять сiм навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 28:
                        {
                            Console.Write("Двадцять вiсiм навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 29:
                        {
                            Console.Write("Двадцять дев'ять навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 30:
                        {
                            Console.Write("Тридцять навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 31:
                        {
                            Console.Write("Тридцять одне навчальне завдання\n");
                            q = 0;
                            break;
                        }
                    case 32:
                        {
                            Console.Write("Тридцять два навчальнi завдання\n");
                            q = 0;
                            break;
                        }
                    case 33:
                        {
                            Console.Write("Тридцять три навчальнi завдання\n");
                            q = 0;
                            break;
                        }
                    case 34:
                        {
                            Console.Write("Тридцять чотири навчальнi завдання\n");
                            q = 0;
                            break;
                        }
                    case 35:
                        {
                            Console.Write("Тридцять п'ять навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 36:
                        {
                            Console.Write("Тридцять шiсть навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 37:
                        {
                            Console.Write("Тридцять сiм навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 38:
                        {
                            Console.Write("Тридцять вiсiм навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 39:
                        {
                            Console.Write("Тридцять дев'ять навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    case 40:
                        {
                            Console.Write("Сорок навчальних завдань\n");
                            q = 0;
                            break;
                        }
                    default:
                        {
                            Console.Write("Введiть число вiд 10 до 40!!!\a\n");
                            Console.ReadKey();
                            break;
                        }
                }
            }while (q != 0);
            Console.ReadKey();
        }
    }
}

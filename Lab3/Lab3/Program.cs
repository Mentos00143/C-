using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Choise, value;
            int choise;
            bool k, p;
            Adress Adr = new Adress();
            do
            {
                Console.Clear();
                p = true;
                Console.Write("Enter name of city: ");
                value = Console.ReadLine();
                Adr.City = value;
                Adr.setStreet();
                Adr.setIndex();
                Adr.setNumber();
                Adr.Show();
                do
                {
                    k = true;
                    Console.Write("Want to change? 1 - yes, 0 - exit: ");
                    Choise = Console.ReadLine();
                    k = int.TryParse(Choise, out choise);
                    if (k == false || (choise != 1 && choise != 0))
                    {
                        k = false;
                        Console.WriteLine("Invalid data!!\a");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (k == false);
                if (choise == 0)
                {
                    p = true;
                }
                else
                {
                    p = false;
                }
            } while (p == false);
        }
    }
}

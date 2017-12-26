using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Adress
    {
        private string city;
        private string street;
        private int index;
        private int number_house;
        public Adress()
        {
            city = "Uzhgorod";
            index = 88015;
            street = "Mozhajskogo";
            number_house = 7;
        }
        public Adress(string City)
        {
            city = City;
            index = 88015;
            street = "Mozhajskogo";
            number_house = 7;
        }
        public string City
        {
            set
            {
                city = value;
            }
            get
            {
                return city;
            }
        }
        public void setStreet()
        {
            Console.Write("Enter name of street: ");
            street = Console.ReadLine();
        }
        public string getStreet()
        {
            return street;
        }
        public void setIndex()
        {
            string ind;
            bool p;
            do
            {
                p = true;
                Console.Write("Enter post index: ");
                ind = Console.ReadLine();
                p = int.TryParse(ind, out index);
                int count = 1, buf = index;
                for(int i = 0;i<15;i++)
                {
                    if(buf/10>1)
                    {
                        count++;
                        buf /= 10;
                    }
                    else
                    {
                        break;
                    }
                }
                if (p == false || index < 0 || count!=5)
                {
                    p = false;
                    Console.WriteLine("Invalid data!!\a");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (p == false);
        }
        public int getIndex()
        {
            return index;
        }
        public void setNumber()
        {
            bool k;
            string num;
            do
            {
                k = true;
                Console.Write("Enter number of house: ");
                num = Console.ReadLine();
                k = int.TryParse(num, out number_house);
                if (k == false || number_house < 0)
                {
                    k = false;
                    Console.WriteLine("Invalid data!!\a");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (k == false);
        }
        public int getNumber()
        {
            return number_house;
        }
        public void Show()
        {
            Console.Clear();
            Console.WriteLine("Name of city: " + City);
            Console.WriteLine("Name of street: " + getStreet());
            Console.WriteLine("Post index: " + getIndex());
            Console.WriteLine("House number: " + getNumber());
        }
        ~Adress()
        {

        }

    }
}

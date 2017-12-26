using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class matrix
    {
        private int i, j, w, e;
        private int[,] arr;
        public matrix()
        {
            i = 100;
            j = 100;
            arr = new int[i,j];
            w = 0;
            e = 0;
            for (int k = 0; k < i; k++)
            {
                for (int l = 0; l < j; l++)
                {
                    this[k,l] = 0;
                }
            }
        }
        private int this[int t, int y]
        {
            set
            {
                arr[t,y] = value;
            }

            get
            {
                return arr[t,y];
            }
        }
        matrix(int I)
        {
            w = 0;
            e = 0;
            i = I;
            j = 100;
            for (int k = 0; k < i; k++)
            {
                for (int l = 0; l < j; l++)
                {
                    arr[k,l] = 0;
                }
            }
        }
        public int GetW()
        {
            return w;
        }
        public int GetE()
        {
            return e;
        }
        public int I
        {
            set
            {
                i = 100;
            }
            get
            {
                return i;
            }
        }
        public void show_dov(int a,int b)
        {
            for(int k=0;k<a;k++)
            {
                for(int l=0;l<b;l++)
                {
                    Console.Write(arr[k,l] + " ");
                }
                Console.Write("\n");
            }
        }
        public void change(int A, int B)
        {
            w = A;
            e = B;
        }
        public void show_all()
        {
            for (int k = 0; k < w; k++)
            {
                for (int l = 0; l < e; l++)
                {
                    Console.Write(arr[k,l] + " ");
                }
                Console.Write("\n");
            }
        }
        public void ent(int a, int b)
        {
            w = a;
            e = b;
            for (int k = 0; k < w; k++)
            {
                for (int l = 0; l < e; l++)
                {
                    Console.Write("arr["+k+"]["+l+"] = ");
                    check(out arr[k,l]);
                }
            }
        }
        public void check(out int q)
        {
            bool g = false;
            string temp;
            do
            {
                temp = Console.ReadLine();
                g = int.TryParse(temp, out q);
            } while (!g);
        }
        public static matrix operator +(matrix a, matrix b)
        {
            matrix O = new matrix();
            for(int k = 0; k<100; k++)
            {
                for(int l = 0; l<100; l++)
                {
                    O.arr[k, l] = a.arr[k, l] + b.arr[k, l];
                }
            }
            return O;
        }
        public void ind(int a, int b)
        {
            Console.WriteLine(arr[a-1,b-1]);
        }
    }
    class Program
    {
        public static void check(out int q)
        {
            bool g = false;
            string temp;
            do
            {
                temp = Console.ReadLine();
                g = int.TryParse(temp, out q);
            } while (!g);
        }
        static void Main(string[] args)
        {
            matrix M = new matrix();
            int choose;
            bool o;
            do
            {
                Console.Clear();
                o = true;
                Console.WriteLine("\t\t\tMenu");
                Console.WriteLine("1 - Enter matrix;");
                Console.WriteLine("2 - Change size;");
                Console.WriteLine("3 - Show submatrix;");
                Console.WriteLine("4 - Show element;");
                Console.WriteLine("5 - Show matrix;");
                Console.WriteLine("0 - Exit;");
                check(out choose);
                switch (choose)
                {
                    case 1:
                        {
                            Console.Clear();
                            int A, B;
                            Console.Write("Enter A: ");
                            check(out A);
                            Console.Write("Enter B: ");
                            check(out B);
                            M.ent(A,B);
                            o = false;
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            int A, B;
                            Console.Write("Enter A: ");
                            check(out A);
                            Console.Write("Enter B: ");
                            check(out B);
                            M.change(A, B);
                            o = false;
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            bool p;
                            int A, B;
                            do
                            {
                                p = true;
                                Console.Clear();
                                Console.Write("Enter A: ");
                                check(out A);
                                Console.Write("Enter B: ");
                                check(out B);
                                if (A > M.GetW() || B > M.GetE())
                                {
                                    Console.WriteLine("Invalid data!");
                                    Console.ReadKey();
                                    p = false;
                                }
                            } while (p == false);
                            M.show_dov(A, B);
                            o = false;
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            int A, B;
                            Console.Write("Рядок: ");
                            check(out A);
                            Console.Write("Стовпець: ");
                            check(out B);
                            M.ind(A, B);
                            o = false;
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            M.show_all();
                            o = false;
                            Console.ReadKey();
                            break;
                        }
                    case 0:
                        {
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid data!!");
                            o = false;
                            Console.ReadKey();
                            break;
                        }
                }

            } while (o==false);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motifs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Read();
        }


        static void Square (int n, char c)
        {
            int l = n;
            int m = n;
            while (n>0)
            {
                while (m>0)
                {
                    Console.Write(c);
                    m--;
                }
                m = l;
                Console.WriteLine();
                n--;
            }
        }

        static void Alternate (int n, char c1 , char c2)
        {
            int l = n;
            int m = n;
            while (n > 0)
            {
                while (m > 0)
                {
                    if (m % 2 == 0)
                        Console.Write(c2);
                    else
                        Console.Write(c1);
                    m--;
                }
                char c = c1;
                c1 = c2;
                c2 = c;
                m = l;
                Console.WriteLine();
                n--;
            }  
        }

        static void Triangle(int n, char c)
        {
            int l = 1;
            while (l <= n)
            {
                int m = 1;
                while (m <= l)
                {
                    m++;
                    Console.Write(c);
                }
                l++;
                Console.WriteLine();
            }
        }

        static void Pyramid(int n, char c)
        {
            int l = 1;
            int i = n-l;
            while (l <= n)
            {
                while (i >= 1)
                {
                    Console.Write(" ");
                    i--;
                }
                int m = 1;
                while (m <= l*2 - 1)
                {
                    m++;
                    Console.Write(c);
                }
                l++;
                Console.WriteLine();
                i = n - l;
            }
        }
    }
}
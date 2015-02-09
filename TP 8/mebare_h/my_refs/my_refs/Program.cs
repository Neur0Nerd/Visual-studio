using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_refs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercice 4.1.1
            //float result = 2.7f;
            //add(ref result, 7.2f);

            //Exercice 4.1.2
            //float result = 2.7f;
            //sub(ref result, 7.2f);

            //Exercice 4.1.3
            //float result = 2.7f;
            //prod(ref result, 7.2f);

            //Exercice 4.1.4
            //float result = 1500.3f;
            //div(ref result, 3.0f);

            //Exercice 4.1.5
            //float n = 2.0f;
            //pow(ref n, 8);

            //Exercice 4.1.6

            //Exercice 4.1.7
        }
        static void add(ref float result, float value)
        {
            result += value;
            Console.WriteLine(result);
            Console.Read();
        }
        static void sub(ref float result, float value)
        {
            result -= value;
            Console.WriteLine(result);
            Console.Read();
        }
        static void prod(ref float result, float value)
        {
            result *= value;
            Console.WriteLine(result);
            Console.Read();
        }
        static bool div(ref float result, float value)
        {
            if (value == 0)
            {
                return value == result;
            }
            else
            {
                return 2 == 2;
            }
        }
        static int pow(ref float n, int p)
        {
            float i = n;
            if (p < 0)
            {
                return (0);
            }
            else
                if (p == 0)
                {
                    return (1);
                }
                else
                {
                    while (p != 0)
                    {
                        n = n * i;
                        p = p - 1;
                    }
                    return (1);
                }
        }
        static void arit(ref float Un, float r, int n)
        {
            Un = Un + n * r;
        }
        static void geom(ref float Un, float q, int n)
        {
            pow(ref q, n);
            Un = q * n;
        }
        static void swap(ref int a, ref int b)
        {
            int c = b;
            b = a;
            a = c;
        }
    }
}

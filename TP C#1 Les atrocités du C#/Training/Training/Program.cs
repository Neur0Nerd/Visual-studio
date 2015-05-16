using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Read();
        }

        static int MyFact (int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Please write a number superior to");
                return 0;
            }
            else
            {
                int fact = 0;
                Console.WriteLine("The factorial of " + n + " is");
                for (int i = 1; i < n; i++)
                {
                    fact = n * i;
                }
                return fact;
            }
        }

        static int MyPow (int x, int n)
        {
            if (x<0 || n<0)
            {
                Console.WriteLine("Please choose numbers superior to");
                return 0;
            }
            else
            {
                int acc = x;
                while (n > 1)
                {
                    x = x * acc;
                    n--;
                }
                return x;
            }
        }

        static int MyPgcd(int a, int b)
        {
            if (a == b)
            {
                return a;
            }
            else
            {
                if (a < b)
                {
                    int c = a;
                    while (a % c != 0 || b % c != 0)
                    {
                        c--;
                    }
                    return c;
                }
                else
                {
                    int c = b;
                    while (a % c != 0 || b % c != 0)
                    {
                        c--;
                    }
                    return c;
                }
            }
        }

        static int MyFibo (int n)
        {
            if (n<0)
            {
                Console.WriteLine("Please write a number superior to");
                return 0;
            }
            else
            {
                if (n==0)
                {
                    return 0;
                }
                if (n==1)
                {
                    return 1;
                }
                else
                {
                    return MyFibo(n - 1) + MyFibo(n - 2);
                }
            }
        }
        static float MySqrt (int n)
        {

        }
    }
}

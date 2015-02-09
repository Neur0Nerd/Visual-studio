using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int[] tab = new int[7] { 3, 2, 3, 1, 3, 4, 1 };
            Console.Write(maxtab(tab, ref max));
            Console.Read();
        }
        static int mintab(int[] tab, ref int min)
        {
            int i = 0;
            min = tab[i];
            int index = 0;
            while (i++ < (tab.Length - 1))
            {
                if (min > tab[i])
                {
                    min = tab[i];
                    index = i;
                }
            }
            return (index);
        }
        static int maxtab(int[] tab, ref int max)
        {
            int i = 0;
            max = tab[i];
            int index = 0;
            while (i++ < (tab.Length - 1))
            {
                if (max < tab[i])
                {
                    max = tab[i];
                    index = i;
                }
            }
            return (index);
        }
        static void bubblesort(int[] tab)
        {
            int temp = 0;
            for (int write = 0; write < tab.Length; write++)
            {
                for (int sort = 0; sort < tab.Length - 1; sort++)
                {
                    if (tab[sort] > tab[sort + 1])
                    {
                        temp = tab[sort + 1];
                        tab[sort + 1] = tab[sort];
                        tab[sort] = temp;
                    }
                }
            }
        }
    }
}
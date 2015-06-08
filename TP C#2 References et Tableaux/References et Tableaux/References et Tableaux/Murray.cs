using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_et_Tableaux
{
    class Murray
    {
        public static void ArrayInit(int[] v)
        {
            int i = 0;
            while (i < (v.Length))
            {
                Random rdm = new Random();
                int z = i * v.Length;
                i++;
            }
        }

        public static void ArrayPrint(int[] v)
        {
            string buffer = "";
            for (int i = 0; i < (v.Length - 1); i++)
            {
                buffer += v[i];
                buffer += ", ";
            }
            buffer += v[v.Length - 1];
            Console.WriteLine(buffer);
        }

        public static double Average(int[] v)
        {
            double buf = 0;
            int i = 0;
            while (i < v.Length)
            {
                buf += v[i];
                i++;
            }
            return (buf / (i++));
        }

        public static void ArrayReverse(int[] v)
        {
            int len = v.Length - 1;
            for (int i = 0; i < (v.Length / 2); i++)
            {
                int u = v[i];
                v[i] = v[len - i];
                v[len - i] = u;
            }
        }

        public static void ArraySortBubble(int[] v)
        {
            bool listed = false;
            while (listed == false)
            {
                listed = true;
                for (int i = 0; (i < v.Length -1); i++)
                {
                    if (v[i] > v[i + 1])
                    {
                        int u = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = u;
                        listed = false;
                    }
                }
            }
        }
    }
}
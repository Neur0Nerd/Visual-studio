using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_et_Tableaux
{
    class Matrix
    {
        public static bool MatrixTrace(double[,] a, ref double b)
        {
            int l = a.GetLength(0);
            int c = a.GetLength(1);
            int i = 0;
            if (c == l)
            {
                while (i<l)
                {
                    b += +a[i, i];
                    i++;
                }
                return true;
            }
            else
            {
                return false;
                
            }
        }

        public static bool MatrixAdd(double[,] a, double[,] b, ref double[,] c)
        {
            int l1 = a.GetLength(0);
            int c1 = a.GetLength(1);
            int l2 = b.GetLength(0);
            int c2 = b.GetLength(1);
            if ((c1 != c2) || (l1 != l2))
            {
                return false;
            }
            else
            {
                for (int i = 0; i < l1; i++)
                {
                    for (int j = 0; j < c1; j++)
                    {
                        c[i, j] = a[i, j] + b[i, j];
                    }
                }
                return true;
            }
        }
    }
}

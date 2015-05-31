using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Des_moules_et_des_gateaux
{
    class Applications
    {
        public static void MultiSetDisplay(MultiSet set)        {
            int size = set.Size();            int i = 0;            while (i <= size)
            {
                Console.WriteLine(set.set[i]);
                i++;
            }        }
    }
}

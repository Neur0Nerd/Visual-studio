using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Des_moules_et_des_gateaux
{
    class MultiSet
    {
        /* ATTRIBUTS */
        public int entier;
        public bool booleen;
        public string element;
        public string[] set;

        /*Empty*/
        public void MultiSet()
        {
            set = new string[5];
        }
        
        /*Insert*/
        public void Insert (string element)
        {
            for (int i = 0 ; i < set.Length ; i++)
            {
                if (set == null)
                {
                    set[i] = element;
                }
                if (i == set.Length - 1)
                {
                    string[] new_tab = new string[set.Length + 1];
                    int x = 0;
                    while (x < new_tab.Length)
                    {
                            new_tab[x] = set[x];
                            x++;
                    }
                    new_tab[x] = element;
                }
            }
        }

        public bool Delete (string element)
        {
            int i = 0;
            while (set[i] != element && i <= set.Length)
            {
                i++;
            }
            if (set[i] == element)
            {
                set[i] = null;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Belong (string element)
        {
            int i = 0;
            while (set[i] != element && i <= set.Length)
            {
                i++;
            }
            if (set[i] == element)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Size()
        {
            int i = 0;
            while (i < set.Length)
            {
                i++;
            }
            return i;
        }

        public int NbOccurences(string element)
        {
            int i = 0;
            int occ = 0;
            while (i <= set.Length)
            {
                if (set[i] == element)
                {
                    occ++;
                }
                i++;
            }
            return occ;
        }

        public string Pop()
        {
            int len = set.Length - 1;
            while (len >= 0 && set[len] == null)
            {
                len--;
            }
            return set[len];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasics
{
    class Shop
    {

        private List<Pony> pony_list;
        private int space;
        public int gold;
        public string name;

        public Shop(string name, int gold)
        {
            this.name = name;
            this.gold = gold;
            pony_list = new List<Pony>();
        }

        public void display()
        {
            Random rdm = new Random();
            space = rdm.Next(1,4);
            foreach (Pony PWN in pony_list)
            {
                PWN.display();
                Console.Write("|");
            }
        }

        public void add_gold(int nb)
        {
            gold += nb;
        }
        public void add_poney(Pony pony)
        {
            pony_list.Add(pony);
        }

        public Pony get_pony()
        {
            Pony pony_temp = pony_list[pony_list.Count - 1];
            pony_list.RemoveAt(pony_list.Count - 1);
            return pony_temp;
        }
    }
}

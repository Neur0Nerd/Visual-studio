using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasics
{
    class Shop
    {
        tamer
        private List<Poney> poney_list;
        private int space;
        public int gold;
        public string name;

        public Shop(string name, int gold)
        {
            this.name = name;
            this.gold = gold;
            poney_list = new List<Poney>();
        }

        public void display()
        {
            Random rdm = new Random();
            space = rdm.Next(1,4);
            foreach (Poney PWN in poney_list)
            {
                PWN.display();
                Console.Write("|");
            }
        }

        public void add_gold(int nb)
        {
            gold += nb;
        }
        public void add_poney(Poney poney)
        {
            poney_list.Add(poney);
        }

        public Poney get_poney()
        {
            Poney poney_temp = poney_list[poney_list.Count - 1];
            poney_list.RemoveAt(poney_list.Count - 1);
            return poney_temp;
        }
    }
}

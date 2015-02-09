using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasics
{
    class Farm
    {
        private List<Poney> poney_list;
        private int space;
        public int gold;
        public string name;

        public Farm(string name, int gold)
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
                for (int i = 0; i < space; i++)
                {
                    Console.Write(" ");
                }
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
    }
}

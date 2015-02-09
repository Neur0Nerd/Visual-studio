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
                while ()
                {

                }
        }

        public void add_gold(int nb);
        public void add_poney(Poney poney);
    }
}

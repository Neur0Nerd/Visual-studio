using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Personnage
    {
        int HP = 100;
        int BasicAtk = 5;
    }

    public class Mage : Personnage
    {
        public Mage()
        {
            int dmg = 10;
            int regen = 15;
            int tour = (2/3);
        }
    }
    public class Guerrier : Personnage
    {
       public Guerrier()
        {
            int PV = 80;
            int dmg = 15;
            int regen = 10;
            int tour = (1/3);
        }
    }

    public class Krysboul : Personnage
    {
        public Krysboul()
        {
            int PV = 1000000;
            int dmg = 1000000;
            int regen = 1000000;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Monstre
    {
        int PV = 50;
        int dmg = 2;
    }

    public class Partiel : Monstre
    {
        public Partiel()
        {
            int PV = 100;
            int dmg = 20;
            int regen = 10;
            int tour = (1/2);
        }
    }

    public class Controle : Monstre
    {
        public Controle()
        {
            int dmg = 5;
            int regen = 5;
        }
    }

    public class TP : Monstre
    {
        public TP()
        {
            int PV = 10;
            int regen = 2;
        }
    }
}
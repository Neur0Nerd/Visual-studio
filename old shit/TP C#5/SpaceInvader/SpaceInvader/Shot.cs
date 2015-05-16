using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvader
{
    class Shot
    {
        public string design;
        public int x;
        public int y;
        public int direction; // 1 ou -1 si le tir descend ou monte
        public bool collision; // si le tir a touché un vaisseau
    }
}

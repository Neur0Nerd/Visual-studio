using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvader
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        int get_param(ref string player_design, ref string enemy_design)
        {
            Console.WriteLine("Assignation of the Player Design");
            string rp = Console.ReadLine();
            player_design = rp;
            Console.WriteLine("Assignation of the Ennemy Design");
            string re = Console.ReadLine();
            player_design = re;
            int dif = 0;
            int idif = Convert.ToInt32(dif);
            do
            {
                try
                {
                    int difficulty = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("The input is not a number superior to 0");
                }
            }
            while (dif < 1);
            return dif;
        }
    }
}
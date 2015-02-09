using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Pony ShowMeYourPonys = new Pony(ConsoleColor.Magenta);
            ShowMeYourPonys.display();

            Farm ferme = new Farm("Toto", 9000);
            ferme.add_pony(ShowMeYourPonys);
            ferme.add_pony(new Pony(ConsoleColor.Red));
            ferme.add_pony(new Pony(ConsoleColor.White));
            ferme.add_pony(new Pony(ConsoleColor.Yellow));

            ferme.display();

            Console.Read();
        }
    }
}

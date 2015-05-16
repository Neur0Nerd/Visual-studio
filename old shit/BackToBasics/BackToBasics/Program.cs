using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasics
{
    class Program
    {
        static void lets_shop(Farm ferme, Shop shop)
        {
            Console.WriteLine("  _ _ ____  _______ ____   ______   ___  ____   ____  ______  ");
            Console.WriteLine("  | | |__|  |  |  |/|___    ||  |    ||__|___   [__|__|  |__] ");
            Console.WriteLine("  |_|_|__|__|__|__| |___    ||__|    ||  |___   ___|  |__|    ");
        }
        static void show_farm(Farm ferme, Shop shop)
        {
            Console.WriteLine("  _ _ ____  _______ ____   ______   ___  ____   __________ _ ");
            Console.WriteLine("  | | |__|  |  |  |/|___    ||  |    ||__|___   |__|__|__|/| ");
            Console.WriteLine("  |_|_|__|__|__|__| |___    ||__|    ||  |___   |  |  |  | | ");
        }

        static void launcher(Farm ferme, Shop shop)
        {
            string choice;
            Console.WriteLine();
            Console.WriteLine("  _ _ ____  _______ ____");
            Console.WriteLine("  | | |__|  |  |  |/|___");
            Console.WriteLine("  |_|_|__|__|__|__| |___");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Press 1 to access the farm ");
            Console.WriteLine(" Press 2 to access the shop ");
            Console.Read();
            do
            {
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        show_farm(ferme, shop);
                        ferme.display();
                        break;

                    case "2":
                        lets_shop(ferme, shop);
                        break;
                }
            } while (0 != 42);
        }
        static void Main(string[] args)
        {

        }
    }
}
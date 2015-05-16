using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();
            Console.Read();
        }

        static void Init()
        {
            Console.Write("Please choose a character (1-3)");
            Console.WriteLine();
            Console.WriteLine(" 1) Mage");
            Console.WriteLine(" 2) Guerrier");
            Console.WriteLine(" 3) Krysboul (this man is OP)");
            string choice = Console.ReadLine();
            Console.Clear();
            Personnage joueur = new Personnage();            
            switch (choice)
            {
                case "1": Console.WriteLine("You chose Mage");
                    joueur = new Mage();
                    break;
                case "2": Console.WriteLine("You chose Guerrier");
                    joueur = new Guerrier();
                    break;
                case "3": Console.WriteLine("You chose Krysboul");
                    joueur = new Krysboul();
                    break;
                default : Console.WriteLine("Please buy the DLC to access more characters");
                    break;
            }
            Console.Write("and you are going to fight against Partiel");
            Monstre Ennemi = new Monstre();
            Ennemi = new Partiel();
         }
    }
}

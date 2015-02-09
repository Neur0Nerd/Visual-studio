using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasics
{
    class Pony
    {
        static Random Rdm = new Random();
        private int length;
        public ConsoleColor couleur;


        public Pony(ConsoleColor couleur)
        {
            ConsoleColor cache = Console.ForegroundColor;
            this.couleur = couleur;
            length = Rdm.Next(2, 10);
        }
        public void display()
        {
            Console.ForegroundColor = couleur;
            Console.Write(".");
            Console.Write(new string ('=',length));
            Console.Write(".°");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
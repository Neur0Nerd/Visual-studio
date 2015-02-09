using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasics
{
    class Poney
    {
        private int length;
        public Poney(ConsoleColor couleur)
        {
            ConsoleColor cache = Console.ForegroundColor;
            Console.ForegroundColor = couleur;
            Random Rdm = new Random();
            length = Rdm.Next(2, 10);
        }
        public void display()
        {
            Console.Write(".");
            Console.Write(new string ('=',length));
            Console.Write(".°");
        }
    }
}
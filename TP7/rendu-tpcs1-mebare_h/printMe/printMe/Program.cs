using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printMe
{
    class Program
    {
        public static void roof()
        {
            System.Console.WriteLine(@"              *");
            System.Console.WriteLine(@"             *");
            System.Console.WriteLine(@"              *");
            System.Console.WriteLine(@"      /\     *");
            System.Console.WriteLine(@"     /  \  _*");
            System.Console.WriteLine(@"    /    \| | ");
            System.Console.WriteLine(@"   /      \ |");
            System.Console.WriteLine(@"  /        \|");
            System.Console.WriteLine(@" /          \");
            System.Console.WriteLine(@"/____________\");
        }

        public static void floor()
        {
            System.Console.WriteLine(@"|    [] []   |");
        }

        public static void ground()
        {
            System.Console.WriteLine(@"|      _     |");
            System.Console.WriteLine(@"|_____|-|____|");
        }

        static void Main(string[] args)
        {
            roof();
            floor();
            ground();
            Console.Read();
        }
    }
}

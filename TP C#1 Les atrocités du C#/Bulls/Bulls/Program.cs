using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulls
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Read();
        }

        static int GetInput ()
        {
            Console.WriteLine("Please write 4 digits");
            Console.WriteLine();
            string i = Console.ReadLine();
            return Convert.ToInt32(i);
        }
    }
}
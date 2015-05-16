using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lipogramme
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Veuillez entrer un texte:");
            string text = System.Console.ReadLine();
            if (lipogramme (text))
            {
                Console.WriteLine("c'est un lipogramme de e!");
            }
            else
            {
                Console.WriteLine("ce n'est pas un lipogramme de e!");
            }
            Console.Read();

        }
        static bool lipogramme(string str)
            {                
            return index(str, 0);
            }
        static bool index(string str, int accu )
        {
            if (accu != str.Length)
            {
                if (str.Substring(accu, 1) == 'e'.ToString() || str.Substring(accu, 1) == 'E'.ToString())
                {
                    return false;
                }
                else
                {
                    return index(str, accu + 1);
                }
            }
            else
            {
                return true;
            }
        }
    }
}
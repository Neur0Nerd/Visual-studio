using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            float result = 2.7f;
            add(ref result, 7.2f);
        }
        static void add(ref float result, float value)
        {
            result = result + value;
            Console.WriteLine(result);
            Console.Read();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello("World");
            SayHello("ACDC");
            SayHello("Mme Cavatorta");
            Console.Read();
        }

        static void SayHello(string target)
        {
            Console.WriteLine("Hello" + " " + target + "!");
        }
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fi_chiers__
{
    class Basics
    {
        public static void MyReader ( string filename )
        {
            StreamReader f = new StreamReader(filename);
            string str;
            try
            {
            while ((str = f.ReadLine()) != null)
            {
                Console.WriteLine (str);
            }
            }
            catch (Exception)
            {
                Console.WriteLine ("File cannot be read");
            }
        }

        public static void MyWriter (string filename)
        {
            if (File.Exists(filename)) 
            {
            string input = Console.ReadLine();
            StreamWriter stream_writer = File.AppendText(filename);
            stream_writer.WriteLine(input);
            stream_writer.Close();
            }
            else
            {
                Console.WriteLine("The file can't be writen, please check if the file exists at this path or if you have a writing access to it.");
                Console.Read();
            }
        }
    }
}

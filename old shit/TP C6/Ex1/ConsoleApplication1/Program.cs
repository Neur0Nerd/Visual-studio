using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "Il", "etait", "une", "fois" };
            write_to_file("filename.txt", lines);           
            Console.Read();
        }

        static String read_file(string filename)
        {
            try
            {
                StreamReader stream_reader = new StreamReader(filename);
                string str = stream_reader.ReadToEnd();
                stream_reader.Close();
                return str;
            }
            catch (Exception)
            {
                Console.WriteLine("File not found");
            }
            return (" ");
        }

        static void write_to_file(string filename, string[] lines)
        {
            StreamWriter stream_writer = new StreamWriter (filename);
            foreach(string bruhhh in lines)
            {
                stream_writer.WriteLine(bruhhh);
            }
            stream_writer.Close();
        }

        private bool is_bitmap(FileStream fs)
        {
            
        }
    }
}
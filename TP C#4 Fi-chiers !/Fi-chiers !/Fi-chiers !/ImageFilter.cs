using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fi_chiers__
{
    class ImageFilter
    {
        public static void ReadBMPInfos (string filename)
        {
           
            FileStream f = new FileStream (filename, FileMode.Open, FileAccess.Read ) ;
            BinaryReader br = new BinaryReader (f) ;
            int fb = f.ReadByte();
            int sb = f.ReadByte();
            if ((fb == 0x42) && (sb == 0x4D))
            {
                Console.WriteLine("height is "+ br.ReadInt32());
                Console.WriteLine("weight is" + br.ReadInt32());
                f.Seek(3, SeekOrigin.Current);
                Console.WriteLine("Bits per pixel : "+ br.ReadInt16());
            }
            
            else
            {
                throw new Exception("This file is not a BitMap");
            }
        }
    }
}

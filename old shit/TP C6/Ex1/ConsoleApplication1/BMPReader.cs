using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApplication1
{
    public class BMPReader
    {
        public int height { get; private set; }
        public int width { get; private set; }
        private int pixel_array_offset;
        private short bits_per_pixel;
        private byte [] header;
        private Color[, ] pixels;
        public void save ( string filename );
        public void display_header ( FileStream fs);
        public Color get_pixel (int x, int  y);
        public void set_pixel (int x, int y, Color c);

        private void read_header ( FileStream fs)
        {
            header = new byte[2];
            header[0] = Convert.ToByte(fs.ReadByte());
            header[1] = Convert.ToByte(fs.ReadByte());
        }

        private void read_pixels ( FileStream fs);

        public BMPReader (string filename) //Constructeur
        {
        } 

        private bool is_bitmap(FileStream fs)
        {
            fs.Seek(0, SeekOrigin.Begin);
            if ((fs.ReadByte() == 0x42) && (fs.ReadByte() == 0x4D) && (fs.ReadByte() != 0x00 || fs.ReadByte() != 0x00 || fs.ReadByte() != 0x00 || fs.ReadByte() != 0x00))
            {
                return true;
            }

            else
                throw new Exception("Not a BMP");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_et_Tableaux
{
    class References
    {
        public static void Swap (ref int a, ref int b)
        {
            int c = b;
            b = a;           
            a = c;
        }

        public static void MaMeMi (ref int a, ref int b, ref int c)
        {
            if (b > c)
            {
                Swap(ref b, ref c);
            }
            if (a > c)
            {
                Swap(ref a, ref c);
            }
            if (a>b)
            {
                Swap(ref a, ref b);
            }
        }
        public static void TimeCorrecter (ref int weeks , ref int days , ref int hours , ref int minutes , ref int seconds )
        {
            while (seconds > 60)
            {
                seconds -= 60;
                minutes = minutes + 1;
            }
            Console.WriteLine(seconds);
            while (minutes  > 60)
            {
                minutes -= 60;
                hours = hours + 1;
            }
            Console.WriteLine(minutes);
            while ( hours > 24)
            {
                hours = hours - 24;
                days = days + 1;
            }
            Console.WriteLine(hours);
            while (days > 7)
            {
                days -= 7;
                weeks = weeks + 1;
            }
            Console.WriteLine(days);
            Console.WriteLine(weeks);
        }
    } 
}

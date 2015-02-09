using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace project
{
    class Program
    {

        static void Main(string[] args)
        {
            print_vader("");
            Console.Read();
        }


        static void who_are_you()
        {
                Console.WriteLine("Please, enter your name");
                string i = Console.ReadLine(); 
                Console.WriteLine("Hi " + i + " !");
                Console.Read();
        }

        static void even_or_odd()
        {
            Console.WriteLine("Please enter a number");
            string num = Console.ReadLine();
            int n = Convert.ToInt32(num);

            if (n % 2 == 0)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.Error.WriteLine("Your number is odd");
            }                                                                                                                                                                                                                                                         
            Console.Read();
        }

        static void greater_or_lower(int sup)
        {
            Console.WriteLine("You have to find a number between 0 and " + sup);
            Console.WriteLine("You think that the number is ...");
            string supposition = Console.ReadLine();
            int given_answer = Convert.ToInt32(supposition);
            int attempt = 1;
            int answer = Convert.ToInt32(sup);
            while (given_answer != answer)
            {
                attempt++;
                if (given_answer < answer)
                {
                    Console.WriteLine("Greater");
                    Console.WriteLine("Enter a new number");
                    supposition = Console.ReadLine();
                    given_answer = Convert.ToInt32(supposition);
                }               
                if (given_answer > answer)
                {
                    Console.WriteLine("Lower");
                    Console.WriteLine("Enter a new number");
                    supposition = Console.ReadLine();
                    given_answer = Convert.ToInt32(supposition);
                }               
            }            
            if (answer == sup)
            {
                Console.WriteLine("Congratulations! The secret number is " + answer + " (found after " + attempt + " attempts)");
            }
            Console.Read();
        }

        static int my_multiplication(uint a, uint b)
        {
            int x = Convert.ToInt32(a);
            int y = Convert.ToInt32(b);
            int somme = 0;
            int i = y;
            while (i != 0)
            {
                i--;
                if (x == 0 || y == 0)
                {
                    return 0;
                }
                else
                {
                    somme = somme + x;
                }
            }
            return somme;
        } 

        static int my_eucl_div(uint a, uint b)
        {
            int x = Convert.ToInt32(a);
            int y = Convert.ToInt32(b);
            int i = 0;
            while ((x > y) && (x!=0))
            {
               i++;
               x = x - y;
            }
            Console.Write(i);
            return i;
        }

        static long my_pow(int n, int pow)
        {
            int somme = 1;
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                 while (pow != 0)
                {
                    pow--;
                    somme = somme * n;
                }
                return somme;
            }           
        }

        static float my_abs(float f)
        {
            if (f==0)
            {
                Console.Write(0);
                return 0;
            }
            else
            {
                {
                    if (f > 0)
                    {
                        Console.Write(f);
                        return f;
                        
                    }
                    else
                    {
                        while (f < 0)
                        {
                            Console.Write(-f);
                            return -f;
                        }
                        Console.Write(f-f);
                        return f-f;
                    }
                }
                
            }           
        }

        static float my_sqrt(int n)
        {
            float f = 2;
            for (int i = 0; i < 20; i++)
                f = 0.5f * (f + n / f);
            return (((float)((int)(f * 100000))) / 100000);
        }

        static long my_fibo_inter(int n)
        {
            int prev = 0;
            int curr = 1;
            int next = 1;
            int iter = 0;
            while (iter++ < n)
            {
                prev = curr;                
                curr = next;
                next = curr + prev;
            }
            return (Convert.ToInt64(next));
        }

        static bool is_prime(int n)
        {
            for (int x=2; x < my_sqrt(n); x++)
            {
                if (n%x == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void jedi_or_sith()
        {
            string a = Console.ReadLine();
            if (is_prime(a.Length))
                Console.WriteLine("Vous etes un Jedi. Que la Force soit avec vous!");
            else
                Console.WriteLine("Tu es un Sith, et bah bravo !");
        }

        static void print_alpha ()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("a");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("b");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("c");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("d");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("e");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("f");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("g");
            Console.ResetColor();
            Console.Write(" je connais mon alphabet");
            SpeechSynthesizer voice = new SpeechSynthesizer();
            voice.Speak("a b c d e f g  je connais mon alphabet");
        }

        static void print_vader(string space)
        {
            int b = 10;
            ConsoleKeyInfo rky;
            Random randomGen = new Random();
            do
            {
                int a = b;
                Console.Clear();
                do
                { 
                Console.WriteLine(); } while (a-- >= 0);
                Console.WriteLine(space + "         _.-'~~~~~~`-._");
                Console.WriteLine(space + "        /      ||      \\");
                Console.WriteLine(space + "       /       ||       \\");
                Console.WriteLine(space + "      |        ||        |");
                Console.WriteLine(space + "      | _______||_______ |");
                Console.WriteLine(space + "      |/ ----- \\/ ----- \\|");
                Console.WriteLine(space + "     /  (     )  (     )  \\");
                Console.WriteLine(space + "    / \\  ----- () -----  / \\");
                Console.WriteLine(space + "   /   \\      /||\\      /   \\");
                Console.WriteLine(space + "  /     \\    /||||\\    /     \\");
                Console.WriteLine(space + " /       \\  /||||||\\  /       \\");
                Console.WriteLine(space + "/_        \\o========o/        _\\");
                Console.WriteLine(space + "  `--...__|`-._  _.-'|__...--'\" ");
                Console.WriteLine(space + "          |    `'    |"); 
                rky = Console.ReadKey();
                if (rky.Key == ConsoleKey.Z)
                {
                    if (b != -1)
                    { b = b - 1;Console.ForegroundColor = ConsoleColor.Red; }
                }
                else if (rky.Key == ConsoleKey.Q)
                {
                    if (space.Length != 0)
                    { space = space.Remove(0, 1);Console.ForegroundColor = ConsoleColor.Yellow; }
                }
                else if (rky.Key == ConsoleKey.S)
                {
                    if (b != Console.WindowHeight - 16)
                    { b = b + 1;Console.ForegroundColor = ConsoleColor.Magenta; }
                }
                else if (rky.Key == ConsoleKey.D)
                {
                    if (space.Length != Console.WindowWidth - 33)
                    { space = space + " ";Console.ForegroundColor = ConsoleColor.Cyan; }
                }
                
            } while (rky.Key != ConsoleKey.Escape);
        }

    }
}
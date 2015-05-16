using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace my_formulaone
{
    class Program
    {
        static bool[][] string_of_int_array(string input, int width)
        {
            int j = (input.Length / width);
			//number of arrays in the array
            bool [][] tab=new bool[j] [];
			//returned board
            for (int p = 0; p <= j; p++)
            {
                tab[p] = new bool[width];
            }
            for (int i = 0; i < input.Length; i++)
            {
                int x = i % width;
                int y = Convert.ToInt32(i / width);
				//coordinates of the cell in the board
                if (input[i] == 'O')
                {
                    tab[y][x] = true;
                }
                else
                {
                    tab[y][x] = false;
                }
            }
            return tab;
        }
        static bool draw_road(bool[][] race, ref int where,ref int car,[int car_length=3,int car_height=3])
        {
			//car_height and car_length change the shape of the car, used to change the difficulty, or change for a 2x4 limousine
			//note: admire the race with a 0x0 ghost car
            Console.Clear();
            if (where>=(race[where].Length)-3) 
			//is the end of the race?
            {
				Console.Write("_______                            _
| ____|  _             _          | |
| |_    |_|       _   |_|   ___   | |_
|  _|    _    ___| |   _   /  _/  |  _ \\
| |     | |  / __  |  | |  \\_  \\  | | \\ |
|_|     |_|  |_| |_|  |_|  |___/  |_| |_|"
                return false;
            }
            else
            {
				int y=0;
				//number of iterations
				bool no_damage=true;
				//did the car hurt a wall?
                for (int t = ToInt32(where/3); t < (where/3)+4; t++)
                {
					int p_car=0;
					//determinate the hit box and position of the car
					
					if (j==0)
					{
						int Lrepeat=where % 3;
					}
					else if (j==4)
					{
						int Lrepeat=3 - (where % 3);
					}
					else
					{
						int Lrepeat=3;
					}
					//number of times a row must be printed
                    for (int j = 0; j < Lrepeat; j++)
                    {
						Console.Write(" |");
                        for (int i = 0; i < race.Length; i++)
                        {
							for (int g<0;g<3;g++)
							{
								if (race[t][i])
								{
									if (p_car>=car & p_car<car+car_length & y < car_height)
									{
										Console.Write("0");
									}
									else{
										Console.Write(" ");
									}
								}
								else
								{
									if (p_car>=car & p_car<car + car_length & y < car_height)
									{
										Console.Write("@");
										no_damage=false;
									}
									else{
										Console.Write("X");
									}
								}
								p_car++;
							}
							y++;
                        }
                        Console.Write("| \n");
						//print a row
                    }
                }
				Thread.sleep;
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo input = Console.ReadKey(); 
					if (input.Key.Equals(ConsoleKey.LeftArrow) & car > 0) 
					{
						car=car-1;
					}
					else if (input.Key.Equals(ConsoleKey.RightArrow) & car < race[0].Length)
					{
						car++
					}
				}
            }
            where++;
            return no_damage;
        }
        static void Main(string[] args)
        {
            bool t=true;
            int w = 0;
            Console.Write("iOiOOOiiOOOOOiiOOOOOiiOOOOOiiOOOOOiiOOOOOiiOOOOOi"[1]=='O');
            bool[][] r = string_of_int_array("iOOOOOiiOOOOOiiOOOOOiiOOOOOiiOOOOOiiOOOOOiiOOOOOi", 7);
            int p=6;
            while (t) 
            {
                t=draw_road(r,ref w,ref p);
            }
        }
    }
}

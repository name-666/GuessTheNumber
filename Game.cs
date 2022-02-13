using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
  static  class Game
    {
       static public  bool exit = false;
        static public void game()
        {

            int dnr = RandomNumber.number();

            Console.WriteLine("Я загадал число.  Попробуй угадать его");
            while (exit)
            {

                int number = int.Parse(Console.ReadLine());

                if (number < dnr)
                {
                    Console.WriteLine("Больше");
                }
                else if (number > dnr)
                {
                    Console.WriteLine("Меньше");
                }
                else
                {
                    Console.WriteLine("Угадал");



                    Console.WriteLine("Ещё хочешь?");

                    string next = Console.ReadLine();
                    if (next.ToLower() == "y" || next.ToLower() == "yes")
                    {
                        game();
                    }
                    else
                    {
                        Console.WriteLine("Пока");
                        exit = false ;
                    }

                }

            }




        }
    }
}

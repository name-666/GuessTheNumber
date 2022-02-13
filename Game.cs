using System;

namespace GuessTheNumber
{
    static class Game
    {
        static public bool exit = false;
        static public void game()
        {

            int dnr = RandomNumber.number();
        start:
            Console.WriteLine("Я загадал число.  Попробуй угадать его");
            while (exit)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < dnr)
                {
                    Console.WriteLine("Больше");
                    Player.count++;
                }
                else if (number > dnr)
                {
                    Player.count++;
                    Console.WriteLine("Меньше");
                }
                else
                {
                    Console.WriteLine($"Угадал!    Число попыток {Player.count}");
                    Console.WriteLine("Ещё хочешь?");

                    string next = Console.ReadLine();
                    if (next.ToLower() == "y" || next.ToLower() == "yes")
                    {
                        goto start;
                    }
                    else
                    {
                        Console.WriteLine("Пока");
                        exit = false;
                    }

                }

            }




        }
    }
}

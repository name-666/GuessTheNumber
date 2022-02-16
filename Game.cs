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
            Console.Write("Я загадал число.  Попробуй угадать его \n\r ваше число: ");
            while (exit)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < dnr)
                {
                    Console.WriteLine($"Загаданное число больше  вашего {number} числа");
                    Player.count++;
                }
                else if (number > dnr)
                {
                    Player.count++;
                    Console.WriteLine($"Загаданное число меньше  вашего {number} числа");
                }
                else
                {
                    Console.WriteLine($"Угадал!  Я загадал число  {dnr}   Число попыток {Player.count}");
                    Console.WriteLine("Ещё хочешь?   yes/no");
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

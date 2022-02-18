using System;

namespace GuessTheNumber
{
    static class Game
    {
         const int maxNumber= 10;
         const int minNumber= 0;
        static public bool exit;
        static public void game()
        {
            Random num = new Random();
           int  dnr =  num.Next(minNumber, maxNumber);
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
                        Console.WriteLine("Я загадал новое число ");
                        dnr = num.Next(minNumber,maxNumber);
                        Player.count = 1;
                        exit = true;
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

using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Привет, Сыграем?     YES/NO");
            string vote = Console.ReadLine();

            if (vote.ToLower() == "NO" || vote.ToLower() == "N")
            {
                Console.WriteLine("Пока");
                Game.exit = false;
            }
            else if (vote.ToLower() == "yes" || vote.ToLower() == "y")
            {
                Game.exit = true;
                Game.game();
            }
            else
            {
                Console.WriteLine("Попробуй в другой раз");
            }
        }
    }
}
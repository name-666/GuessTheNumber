using System;

namespace GuessTheNumber
{
    class Program
    {
    

        static void Main(string[] args)
        {
            

            Console.WriteLine($"Привет, Сыграем?" +
                $"" +
                $"YES/NO");
            string vote = Console.ReadLine();

            if (vote.ToLower() == "NO")
            {
                Console.WriteLine("Пока");
            }
            else if (vote.ToLower() == "yes")
            {
                game();
            }
            else
            {
                return;
            }


        }

        static public void game()
        {
            Random rnd = new();
            int dnr = rnd.Next(0,10);
            
            Console.WriteLine("Я загадал число.  Попробуй угадать его");
            while (true)
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
                        break;
                    }

                }

            }
           



        }


    }
}

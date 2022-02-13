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
                Game.exit = true;
                Game.game();
              }
              else
              {
                  return;
              }


          }

          
  

        
    }
}

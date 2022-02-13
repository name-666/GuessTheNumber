using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    static class RandomNumber
    {
        static private readonly Random rnd = new();
        static private readonly int i = rnd.Next(1, 10);
      static public int number()
        {
            return i;
        }
        
    }
}

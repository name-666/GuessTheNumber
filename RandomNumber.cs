using System;


namespace GuessTheNumber
{
    static class RandomNumber
    {
        static private readonly Random rnd = new();
        static private readonly int i = rnd.Next(1, 999);
        static public int number() => i;
    }
}

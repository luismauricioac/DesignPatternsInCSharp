using System;
namespace DesignPatternsInCSharp.DesignPatterns.Strategy
{
    public class EyeWinkingStrategy : IDrunken
    {
        public void Seduce()
        {
            Console.WriteLine("Eye winking");
        }
    }
}


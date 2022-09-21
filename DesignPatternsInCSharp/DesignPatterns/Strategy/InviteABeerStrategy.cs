using System;
namespace DesignPatternsInCSharp.DesignPatterns.Strategy
{
    public class InviteABeerStrategy : IDrunken
    {
        public void Seduce()
        {
            Console.WriteLine("Invite a beer");
        }
    }
}


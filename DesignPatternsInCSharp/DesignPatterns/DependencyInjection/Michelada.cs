using System;
namespace DesignPatternsInCSharp.DesignPatterns.DependencyInjection
{
    public class Michelada : IDrink
    {
        private string type;

        public Michelada(string type)
        {
            this.type = type;
        }

        public void MakeCocktail()
        {
            Console.WriteLine("a michelada " + type + " is made");
        }
    }
}


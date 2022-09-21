using System;
namespace DesignPatternsInCSharp.DesignPatterns.DependencyInjection
{
    public class Bartender
    {
        private IDrink drink;

        public Bartender(IDrink drink)
        {
            this.drink = drink;
        }

        public void MakeCocktail()
        {
            this.drink.MakeCocktail();
        }
    }
}


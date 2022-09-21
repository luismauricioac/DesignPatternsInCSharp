using System;
namespace DesignPatternsInCSharp.DesignPatterns.DependencyInjection
{
    public class Runner
    {
        public Runner()
        {
            IDrink piñaColada = new PiñaColada();
            Bartender bartender = new Bartender(piñaColada);
            bartender.MakeCocktail();

            IDrink michelada = new Michelada("picante");
            bartender = new Bartender(michelada);
            bartender.MakeCocktail();
        }
    }
}


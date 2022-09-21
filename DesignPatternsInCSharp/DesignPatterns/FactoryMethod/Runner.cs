using System;
namespace DesignPatternsInCSharp.DesignPatterns.FactoryMethod
{
    public class Runner
    {
        public Runner()
        {
            var drink = BeverageMaker.make(BeverageMaker.BEER);
            Console.WriteLine(drink.HowMuchItIntoxicatesMe());

            var drink2 = BeverageMaker.make(BeverageMaker.RED_WINE);
            Console.WriteLine(drink2.HowMuchItIntoxicatesMe());
        }
    }
}


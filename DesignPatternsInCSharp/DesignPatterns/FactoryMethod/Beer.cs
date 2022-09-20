using System;
namespace DesignPatternsInCSharp.DesignPatterns.FactoryMethod
{
    public class Beer : IntoxicatingDrink
    {
        public override int HowMuchItIntoxicatesMe()
        {
            return 5;
        }
    }
}


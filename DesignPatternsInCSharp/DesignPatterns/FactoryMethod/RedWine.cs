using System;
namespace DesignPatternsInCSharp.DesignPatterns.FactoryMethod
{
    public class RedWine : IntoxicatingDrink
    {
        public override int HowMuchItIntoxicatesMe()
        {
            return 20;
        }
    }
}


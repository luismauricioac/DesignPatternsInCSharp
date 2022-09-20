using System;
namespace DesignPatternsInCSharp.DesignPatterns.FactoryMethod
{
    public class BeverageMaker
    {
        public const int RED_WINE = 1;
        public const int BEER = 2;

        public static IntoxicatingDrink make(int Type)
        {
            switch (Type)
            {
                case RED_WINE:
                    return new RedWine();
                case BEER:
                    return new Beer();
                default:
                    return null;
            }
        }
    }
}


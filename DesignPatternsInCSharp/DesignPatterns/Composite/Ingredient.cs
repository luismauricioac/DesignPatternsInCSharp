using System;
namespace DesignPatternsInCSharp.DesignPatterns.Composite
{
    public class Ingredient : Component
    {
        public int Quantity { get; set; }
        public string Unit { get; set; }

        public Ingredient(string Name, decimal Cost, int Quantity, string Unit) : base(Name, Cost)
        {
            this.Quantity = Quantity;
            this.Unit = Unit;
        }
    }
}


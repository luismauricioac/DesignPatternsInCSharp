using System;
namespace DesignPatternsInCSharp.DesignPatterns.Composite
{
    public abstract class Component
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }

        public Component(string Name, decimal Cost)
        {
            this.Name = Name;
            this.Cost = Cost;
        }
    }
}


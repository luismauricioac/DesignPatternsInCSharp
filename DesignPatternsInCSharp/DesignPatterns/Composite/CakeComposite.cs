using System;
namespace DesignPatternsInCSharp.DesignPatterns.Composite
{
    public class CakeComposite : Component
    {
        private List<Component> ingredients = new List<Component>();

        public decimal TotalCost
        {
            get
            {
                decimal total = 0;
                foreach (var oElement in this.ingredients)
                {
                    if (oElement.GetType().Name == "CakeComposite")
                        total += ((CakeComposite)oElement).TotalCost;
                    else
                        total += oElement.Cost;
                }
                return total;
            }
        }

        public CakeComposite(string Name, decimal Cost=0) : base(Name, Cost)
        {
        }

        public void Add(Component oElement)
        {
            this.ingredients.Add(oElement);
        }

        public void Remove(Component oElement)
        {
            this.ingredients.Remove(oElement);
        }


    }
}


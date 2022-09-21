using System;
namespace DesignPatternsInCSharp.DesignPatterns.Composite
{
    public class Runner
    {
        public Runner()
        {
            Ingredient ingredient1 = new Ingredient("Flour", 100, 200, "grams");
            Ingredient ingredient2 = new Ingredient("Milk", 20, 1, "liter");
            Ingredient ingredient3 = new Ingredient("Egg", 20, 100, "grams");

            CakeComposite oCake1 = new CakeComposite("Cake");
            oCake1.Add(ingredient1);
            oCake1.Add(ingredient2);
            oCake1.Add(ingredient3);

            Console.WriteLine(oCake1.Name + " " + oCake1.TotalCost);

            Ingredient ingredient4 = new Ingredient("Chocolate", 200, 1, "liter");

            CakeComposite oCake2 = new CakeComposite("Chocolate Cake");
            oCake2.Add(ingredient4);
            oCake2.Add(oCake1);

            Console.WriteLine(oCake2.Name + " " + oCake2.TotalCost);
        }
    }
}


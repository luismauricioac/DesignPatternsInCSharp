using System;
namespace DesignPatternsInCSharp.DesignPatterns.PrototypeShallow
{
    public class Runner
    {
        public Runner()
        {
            Animal oAnimal = new Animal() { Name = "Dolly sheep", Legs = 4 };
            Animal oAnimalClone = oAnimal.Clone() as Animal;
            oAnimalClone.Legs = 5;
            Console.WriteLine(oAnimal.Legs);
        }
    }
}


using System;
namespace DesignPatternsInCSharp.DesignPatterns.PrototypeDeep
{
    public class Runner
    {
        public Runner()
        {
            Animal oAnimal = new Animal() { Name = "Dolly", Legs = 4 };
            Characteristics characteristics = new Characteristics();
            characteristics.Color = "White";
            characteristics.Breed = "sheep";
            oAnimal.Characteristics = characteristics;
            Animal oAnimalClone = oAnimal.Clone() as Animal;
            oAnimalClone.Characteristics.Color = "Black";
            oAnimalClone.Name = "Black";
            Console.WriteLine("Original " + oAnimal.Name);
            Console.WriteLine("Cloned " + oAnimalClone.Name);
            Console.WriteLine("Original " + oAnimal.Characteristics.Color);
            Console.WriteLine("Cloned " + oAnimalClone.Characteristics.Color);
        }
    }
}


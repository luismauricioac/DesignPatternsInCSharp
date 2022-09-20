using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.DesignPatterns.PrototypeDeep
{
    public class Animal : ICloneable
    {
        public int Legs { get; set; }
        public string Name { get; set; }

        public Characteristics Characteristics { get; set; }

        public object Clone()
        {
            Animal clone = this.MemberwiseClone() as Animal;
            Characteristics characteristics = new Characteristics();
            characteristics.Breed = this.Characteristics.Breed;
            characteristics.Color = this.Characteristics.Color;
            clone.Characteristics = characteristics;
            return clone;
        }
    }
}

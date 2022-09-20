using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.DesignPatterns.PrototypeShallow
{
    public class Animal : ICloneable
    {
        public int Legs { get; set; }
        public string Name { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

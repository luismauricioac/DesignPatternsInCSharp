using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.DesignPatterns.Singleton
{
    public class SingletonExample
    {
        private static SingletonExample instance;

        public string message = "";

        public SingletonExample() 
        {
            message = "Hello World";
        }
        public static SingletonExample Instance 
        { 
            get 
            {
                if (instance == null)
                    instance = new SingletonExample();    
                return instance; 
            } 
        }
    }
}

using System;
namespace DesignPatternsInCSharp.DesignPatterns.Singleton
{
    public class Runner
    {
        public Runner()
        {
            Console.WriteLine(SingletonExample.Instance.message);
            SingletonExample.Instance.message = "Hello Mars";
            Console.WriteLine(SingletonExample.Instance.message);
        }
    }
}


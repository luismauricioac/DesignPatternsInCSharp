using System;
namespace DesignPatternsInCSharp.DesignPatterns.Strategy
{
    public class PutOnAGallantFaceStrategy : IDrunken
    {
        public void Seduce()
        {
            Console.WriteLine("Put on a gallant face");
        }
    }
}


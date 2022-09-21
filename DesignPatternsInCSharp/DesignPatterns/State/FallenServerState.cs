using System;
namespace DesignPatternsInCSharp.DesignPatterns.State
{
    public class FallenServerState : ServerState
    {
        public override void Respond()
        {
            Console.WriteLine("Response 500 NOK");
        }
    }
}


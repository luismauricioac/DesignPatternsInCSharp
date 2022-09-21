using System;
namespace DesignPatternsInCSharp.DesignPatterns.State
{
    public class AvailableServerState : ServerState
    {
        public override void Respond()
        {
            Console.WriteLine("Response 200 OK");
        }
    }
}


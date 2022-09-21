using System;
namespace DesignPatternsInCSharp.DesignPatterns.State
{
    public class OverloadedServerState : ServerState
    {
        public override void Respond()
        {
            Task.Delay(500);
            Console.WriteLine("Response 200 OK with 0.5 second of delay");
        }
    }
}


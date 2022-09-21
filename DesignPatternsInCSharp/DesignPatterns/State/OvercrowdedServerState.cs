using System;
namespace DesignPatternsInCSharp.DesignPatterns.State
{
    public class OvercrowdedServerState : ServerState
    {
        public override void Respond()
        {
            Task.Delay(1000);
            Console.WriteLine("Response 200 OK with 1 second of delay");
        }
    }
}


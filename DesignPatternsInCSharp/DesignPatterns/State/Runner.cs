using System;
namespace DesignPatternsInCSharp.DesignPatterns.State
{
    public class Runner
    {
        public Runner()
        {
            ServerContext oServer = new ServerContext();
            oServer.State = new AvailableServerState();
            oServer.attendRequest();

            oServer.State = new OverloadedServerState();
            oServer.attendRequest();
            oServer.attendRequest();

            oServer.State = new OvercrowdedServerState();
            oServer.attendRequest();
            oServer.attendRequest();

            oServer.State = new FallenServerState();
            oServer.attendRequest();

            oServer.State = new AvailableServerState();
            oServer.attendRequest();
        }
    }
}


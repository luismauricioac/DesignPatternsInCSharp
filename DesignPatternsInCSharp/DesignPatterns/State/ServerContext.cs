using System;
namespace DesignPatternsInCSharp.DesignPatterns.State
{
    public class ServerContext
    {
        private ServerState state;

        public ServerState State
        {
            get { return state; }
            set { state = value; }
        }

        public void attendRequest()
        {
            this.state.Respond();
        }
    }
}


using System;
namespace DesignPatternsInCSharp.DesignPatterns.Mediator
{
    public class Mediator : IMediator
    {
        public List<IColleague> colleagues;

        public Mediator()
        {
            this.colleagues = new List<IColleague>();
        }

        public void Add(IColleague colleague)
        {
            this.colleagues.Add(colleague);
        }

        public void Send(string message, IColleague colleague)
        {
            foreach(var c in this.colleagues)
            {
                if(colleague != c)
                {
                    c.Receive(message);
                }
            }
        }
    }
}


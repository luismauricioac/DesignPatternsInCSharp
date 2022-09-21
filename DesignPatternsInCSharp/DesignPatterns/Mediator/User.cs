using System;
namespace DesignPatternsInCSharp.DesignPatterns.Mediator
{
    public class User : IColleague
    {
        public User(IMediator mediator) : base(mediator)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine("An user receive: " + message);
        }
    }
}


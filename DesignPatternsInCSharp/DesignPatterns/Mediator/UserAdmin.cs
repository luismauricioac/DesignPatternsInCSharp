using System;
namespace DesignPatternsInCSharp.DesignPatterns.Mediator
{
    public class UserAdmin : IColleague
    {
        public UserAdmin(IMediator mediator) : base(mediator)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine("An administrator receive: " + message);
        }
    }
}


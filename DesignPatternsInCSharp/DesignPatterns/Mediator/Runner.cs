using System;
namespace DesignPatternsInCSharp.DesignPatterns.Mediator
{
    public class Runner
    {
        public Runner()
        {
            Mediator mediator = new Mediator();
            IColleague oUser = new User(mediator);
            IColleague oAdmin = new UserAdmin(mediator);
            IColleague oAdmin2 = new UserAdmin(mediator);
            mediator.Add(oUser);
            mediator.Add(oAdmin);
            mediator.Add(oAdmin2);
            oUser.Communicate("Houston, we have a problem");
        }
    }
}


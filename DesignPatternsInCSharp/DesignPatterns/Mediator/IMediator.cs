using System;
namespace DesignPatternsInCSharp.DesignPatterns.Mediator
{
    public interface IMediator
    {
        void Send(string message, IColleague colleague);
    }
}


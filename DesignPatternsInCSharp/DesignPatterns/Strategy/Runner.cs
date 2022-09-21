using System;
namespace DesignPatternsInCSharp.DesignPatterns.Strategy
{
    public class Runner
    {
        public Runner()
        {
            var context = new DrunkenStrategiesContext();
            context.Seduce(DrunkenBehaviorsEnum.EyeWinking);
            context.Seduce(DrunkenBehaviorsEnum.InviteABeer);
            context.Seduce(DrunkenBehaviorsEnum.PutOnAGallantFace);
        }
    }
}


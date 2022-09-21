using System;
namespace DesignPatternsInCSharp.DesignPatterns.Strategy
{
    public class DrunkenStrategiesContext
    {
        public IDrunken oDrunken;

        public DrunkenStrategiesContext()
        {
            // by default
            this.oDrunken = new EyeWinkingStrategy();
        }

        public void Seduce(DrunkenBehaviorsEnum option)
        {
            switch (option)
            {
                case DrunkenBehaviorsEnum.EyeWinking:
                    this.oDrunken = new EyeWinkingStrategy();
                    break;
                case DrunkenBehaviorsEnum.InviteABeer:
                    this.oDrunken = new InviteABeerStrategy();
                    break;
                case DrunkenBehaviorsEnum.PutOnAGallantFace:
                    this.oDrunken = new PutOnAGallantFaceStrategy();
                    break;
            }
            this.oDrunken.Seduce();
        }
    }
}


using System;
using System.Collections.Generic;

namespace Pathfinder.Generators.Background.Providers
{
    internal class FiendAdoptedRaceProvider : IAdoptedRaceProvider
    {

        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(96, 100, dieValue);
        }

        public AdoptiveRace GetAdoptiveRace()
        {
            return new AdoptiveRace()
            {
                RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.FiendRaised,
                Traits = new List<ITrait>()
                {
                    new FiendBloodTrait()
                },

                StoryFeats = new List<IStoryFeats>()
                {
                    new DamnedStoryFeat()
                }
            };
        }
    }
}

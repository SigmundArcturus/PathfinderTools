using System;
using System.Collections.Generic;

namespace Pathfinder.Generators.Background.Providers
{
    internal class BeastsAdoptedRaceProvider : IAdoptedRaceProvider
    {

        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(20, 25, dieValue);
        }

        public AdoptiveRace GetAdoptiveRace()
        {
            return new AdoptiveRace()
            {
                RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.RaisedByBeasts,
                Traits = new List<ITrait>()
                {
                    new ResilientTrait()
                },
                StoryFeats = new List<IStoryFeats>()
                {
                    new FeralHeartStoryFeat()
                }
            };
        }
    }
}

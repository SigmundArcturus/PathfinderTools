using System;
using System.Collections.Generic;

namespace Pathfinder.Generators.Background.Providers
{
    internal class DeadAdoptedRaceProvider : IAdoptedRaceProvider
    {

        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(11, 13, dieValue);
        }

        public AdoptiveRace GetAdoptiveRace()
        {
            return new AdoptiveRace()
            {
                RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.RaisedAmongTheDead,
                Traits = new List<ITrait>()
                {
                    new DeathtouchedTrait(),
                    new MagicalKnackTrait()
                },
                StoryFeats = new List<IStoryFeats>()
                {
                    new GlimpseBeyondStoryFeat()
                }
            };
        }
    }
}

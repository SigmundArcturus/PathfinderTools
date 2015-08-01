using System;
using System.Collections.Generic;

namespace Pathfinder.Generators.Background.Providers
{
    internal class AngelsAdoptedRaceProvider : IAdoptedRaceProvider
    {

        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(14, 19, dieValue);
        }

        public AdoptiveRace GetAdoptiveRace()
        {
            return new AdoptiveRace()
            {
                RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.RaisedByAngels,
                Traits = new List<ITrait>()
                {
                    new BlessedTrait()
                }
            };
        }
    }
}

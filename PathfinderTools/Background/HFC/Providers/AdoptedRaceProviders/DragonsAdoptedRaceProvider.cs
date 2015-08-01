using System;
using System.Collections.Generic;

namespace Pathfinder.Generators.Background.Providers
{
    internal class DragonsAdoptedRaceProvider : IAdoptedRaceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(1, 5, dieValue);
        }

        public AdoptiveRace GetAdoptiveRace()
        {
            return new AdoptiveRace()
            {
                RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.AdoptedByDragons,
                Traits = new List<ITrait>()
                {
                    new BloodOfDragonsTrait(),
                    new MagicalKnackTrait()
                }
            };
        }
    }
}

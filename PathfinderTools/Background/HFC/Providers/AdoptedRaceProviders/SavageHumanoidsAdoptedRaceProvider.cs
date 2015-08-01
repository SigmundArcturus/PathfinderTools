using System;
using System.Collections.Generic;

namespace Pathfinder.Generators.Background.Providers
{
    internal class SavageHumanoidsAdoptedRaceProvider : IAdoptedRaceProvider
    {

        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(71, 95, dieValue);
        }

        public AdoptiveRace GetAdoptiveRace()
        {
            return new AdoptiveRace()
            {
                RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.RaisedBySavageHumanoids,
                Traits = new List<ITrait>()
                {
                    new SavageTrait()
                }
            };
        }
    }
}

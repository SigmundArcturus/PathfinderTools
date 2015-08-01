using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class FeyAdoptedRaceProvider : IAdoptedRaceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(6, 10, dieValue);
        }

        public AdoptiveRace GetAdoptiveRace()
        {
            return new AdoptiveRace()
            {
                RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.AdoptedByTheFey,
                Traits = new List<ITrait>()
                {
                    new CharmingTrait(),
                    new MagicalKnackTrait()
                }
            };
        }
    }
}

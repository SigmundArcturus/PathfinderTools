using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pathfinder.Generators.Background.Providers;

namespace Pathfinder.Generators.Background
{
    public class AdoptedSiblingRaceTable
    {
        private static List<IAdoptedSiblingRaceProvider> adoptedRaceProviders = TableHelper.GetProviderList<IAdoptedSiblingRaceProvider>();

        public static BackgroundEnums.RaceTypes GenerateRace(int dieValue)
        {
            foreach (IAdoptedSiblingRaceProvider adoptedRaceProvider in adoptedRaceProviders)
            {
                if (adoptedRaceProvider.IsWithinRange(dieValue))
                    return adoptedRaceProvider.GetSiblingRace();
            }

            return 0;
        }

        public static BackgroundEnums.RaceTypes GenerateRace() 
        {
            return GenerateRace(RandomDieGenerator.D100);
        }
    }
}

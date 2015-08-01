using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using Pathfinder.Generators.Background.Providers;

namespace Pathfinder.Generators.Background
{
    public static class AdoptedOutsideYourRaceTable
    {
        private static List<IAdoptedRaceProvider> adoptedRaceProviders = TableHelper.GetProviderList<IAdoptedRaceProvider>();

        public static AdoptiveRace GenerateRace(int dieValue)
        {
            foreach (IAdoptedRaceProvider adoptedRaceProvider in adoptedRaceProviders)
            {
                if (adoptedRaceProvider.IsWithinRange(dieValue))
                    return adoptedRaceProvider.GetAdoptiveRace();
            }

            return new AdoptiveRace();
        }

        public static AdoptiveRace GenerateRace()
        {
            return GenerateRace(RandomDieGenerator.D100);
        }
    }
}

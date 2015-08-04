using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pathfinder.Generators.Background.Providers;

namespace Pathfinder.Generators.Background
{
    public static class SiblingTable
    {
        static Sibling sibling;

        private static List<IAdoptedSiblingRaceProvider> adoptedSiblingRaceProvider = TableHelper.GetProviderList<IAdoptedSiblingRaceProvider>();
        private static List<IRelativeSiblingAgeProvider> relativeSiblingAgeProvider = TableHelper.GetProviderList<IRelativeSiblingAgeProvider>();

        public static Sibling GenerateSibling(bool isAdopted)
        {
            sibling = new Sibling();

            if (isAdopted) { GenerateSiblingRace(RandomDieGenerator.D100); }
            do
            {
                GenerateSiblingAge(RandomDieGenerator.D100);
            } while (isAdopted && sibling.RelativeAge == BackgroundEnums.RelativeSiblingAge.Twin);
            
            return sibling;
        }

        private static void GenerateSiblingRace(int dieValue)
        {
            foreach (IAdoptedSiblingRaceProvider adoptedRaceProvider in adoptedSiblingRaceProvider)
            {
                if (adoptedRaceProvider.IsWithinRange(dieValue))
                   sibling.Race = adoptedRaceProvider.GetSiblingRace();
            }

        }

        private static void GenerateSiblingAge(int dieValue)
        {
            foreach (IRelativeSiblingAgeProvider relativeSiblingAge in relativeSiblingAgeProvider)
            {
                if (relativeSiblingAge.IsWithinRange(dieValue))
                    sibling.RelativeAge = relativeSiblingAge.GetSiblingAge();
            }
        }
    }
}

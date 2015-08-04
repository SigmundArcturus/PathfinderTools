using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pathfinder.Generators.Background.Providers;

namespace Pathfinder.Generators.Background
{
    class RelativeSiblingAgeTable
    {
        private static List<IRelativeSiblingAgeProvider> ageProviders = TableHelper.GetProviderList<IRelativeSiblingAgeProvider>();

        public static BackgroundEnums.RelativeSiblingAge GenerateAge(int dieValue)
        {
            foreach (IRelativeSiblingAgeProvider ageProvider in ageProviders)
            {
                if (ageProvider.IsWithinRange(dieValue))
                    return ageProvider.GetSiblingAge();
            }

            return 0;
        }

        public static BackgroundEnums.RelativeSiblingAge GenerateAge()
        {
            return GenerateAge(RandomDieGenerator.D100);
        }
    }
}

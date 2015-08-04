using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pathfinder.Generators.Background.Providers;

namespace Pathfinder.Generators.Background
{
    static class NobilityTable
    {
        private static List<INobilityProvider> nobilityProviders = TableHelper.GetProviderList<INobilityProvider>();

        static public Nobility GenerateNobility(int dieValue)
        {
            foreach (INobilityProvider nobilityProvider in nobilityProviders)
            {
                if (nobilityProvider.IsWithinRange(dieValue))
                    return nobilityProvider.GetNobility();
            }
            return null;
        }

        static public Nobility GenerateNobility()
        {
            return GenerateNobility(RandomDieGenerator.D100);
        }
    }
}

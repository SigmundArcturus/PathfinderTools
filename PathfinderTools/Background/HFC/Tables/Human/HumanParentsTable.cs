using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pathfinder.Generators.Background.Providers;

namespace Pathfinder.Generators.Background
{
    public class HumanParentsTable : IParentsTable
    {
        private static List<IHumanParentsProvider> parentsProviders = TableHelper.GetProviderList<IHumanParentsProvider>();

        public Parents GenerateParents(int dieValue)
        {
            foreach (IHumanParentsProvider parentsProvider in parentsProviders)
            {
                if (parentsProvider.IsWithinRange(dieValue))
                    return parentsProvider.GetParents();
            }

            return new Parents();
        }

        public Parents GenerateParents()
        {
           return GenerateParents(RandomDieGenerator.D100);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pathfinder.Generators.Background.Providers;

namespace Pathfinder.Generators.Background
{
    public class HalflingParentsTable : IParentsTable
    {
        private static List<IHalflingParentsProvider> parentsProviders = TableHelper.GetProviderList<IHalflingParentsProvider>();

        public Parents GenerateParents(int dieValue)
        {
            foreach (IHalflingParentsProvider parentsProvider in parentsProviders)
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

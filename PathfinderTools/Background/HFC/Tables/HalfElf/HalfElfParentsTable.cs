using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pathfinder.Generators.Background.Providers;
namespace Pathfinder.Generators.Background
{
    public class HalfElfParentsTable : IParentsTable
    {
        private static List<IHalfElfParentsProvider> parentsProviders = TableHelper.GetProviderList<IHalfElfParentsProvider>();

        public Parents GenerateParents(int dieValue)
        {
            foreach (IHalfElfParentsProvider parentsProvider in parentsProviders)
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

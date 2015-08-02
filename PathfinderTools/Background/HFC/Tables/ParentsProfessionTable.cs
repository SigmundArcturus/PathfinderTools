using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pathfinder.Generators.Background.Providers;
namespace Pathfinder.Generators.Background
{
    class ParentsProfessionTable
    {
        private static List<IParentsProfessionProvider> parentsProfessionProviders = TableHelper.GetProviderList<IParentsProfessionProvider>();

        public ParentsProfession GenerateProfession(int dieValue)
        {
            foreach (IParentsProfessionProvider parentsProfessionProvider in parentsProfessionProviders)
            {
                if (parentsProfessionProvider.IsWithinRange(dieValue))
                    return parentsProfessionProvider.GetParentsProfession();
            }
                        
            return new ParentsProfession();

        }

        public ParentsProfession GenerateProfession()
        {
            return GenerateProfession(RandomDieGenerator.D100);
        }
    }
}

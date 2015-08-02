using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pathfinder.Generators.Background.Providers;

namespace Pathfinder.Generators.Background
{
    public class ElfHomelandTable : IHomelandTable
    {
        private static List<IElfHomelandProvider> homelandProviders = TableHelper.GetProviderList<IElfHomelandProvider>();
        public Homeland GenerateHomeland(int dieValue)
        {

            foreach (IElfHomelandProvider homelandProvider in homelandProviders)
            {
                if (homelandProvider.IsWithinRange(dieValue))
                    return homelandProvider.GetHomeland();
            }

            return new Homeland();
        }

        public Homeland GenerateHomeland()
        {
            return GenerateHomeland(RandomDieGenerator.D100);
        }
    }
}

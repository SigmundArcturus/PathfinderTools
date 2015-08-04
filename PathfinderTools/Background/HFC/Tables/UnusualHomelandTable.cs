using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pathfinder.Generators.Background.Providers;

namespace Pathfinder.Generators.Background
{
    public class UnusualHomelandTable : IHomelandTable
    {
        private static List<IHomelandProvider> homelandProviders = TableHelper.GetProviderList<IHomelandProvider>();

        public Homeland GenerateHomeland(int dieValue)
        {
            foreach (IHomelandProvider homelandProvider in homelandProviders)
            {
                if (homelandProvider.IsWithinRange(dieValue))
                    return homelandProvider.GetHomeland();
            }

            return null;
        }

        public Homeland GenerateHomeland()
        {
            return GenerateHomeland(RandomDieGenerator.D100);
        }
    }
}

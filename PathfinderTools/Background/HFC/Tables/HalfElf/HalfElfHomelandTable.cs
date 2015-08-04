using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pathfinder.Generators.Background.Providers;

namespace Pathfinder.Generators.Background
{
    public class HalfElfHomelandTable : IHomelandTable
    {
        private static List<IHalfElfHomelandProvider> homelandProviders = TableHelper.GetProviderList<IHalfElfHomelandProvider>();
        public Homeland GenerateHomeland(int dieValue)
        {
            foreach (IHalfElfHomelandProvider homelandProvider in homelandProviders)
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

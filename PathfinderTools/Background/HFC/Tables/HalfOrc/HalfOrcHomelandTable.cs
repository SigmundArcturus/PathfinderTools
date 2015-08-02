using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pathfinder.Generators.Background.Providers;

namespace Pathfinder.Generators.Background
{
    public class HalfOrcHomelandTable : IHomelandTable
    {
        private static List<IHalfOrcHomelandProvider> homelandProviders = TableHelper.GetProviderList<IHalfOrcHomelandProvider>();
        public Homeland GenerateHomeland(int dieValue)
        {

            foreach (IHalfOrcHomelandProvider homelandProvider in homelandProviders)
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

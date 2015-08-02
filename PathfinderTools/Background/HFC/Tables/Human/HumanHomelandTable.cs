using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pathfinder.Generators.Background.Providers;

namespace Pathfinder.Generators.Background
{
    public class HumanHomelandTable : IHomelandTable
    {
        private static List<IHumanHomelandProvider> homelandProviders = TableHelper.GetProviderList<IHumanHomelandProvider>();
        public Homeland GenerateHomeland(int dieValue)
        {

            foreach (IHumanHomelandProvider homelandProvider in homelandProviders)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pathfinder.Generators.Background.Providers;

namespace Pathfinder.Generators.Background
{
    public class CircumstancesOfBirthTable
    {
        private static List<IBirthCircumstanceProvider> birthCircumstanceProviders = TableHelper.GetProviderList<IBirthCircumstanceProvider>();

        public CircumstanceOfBirth GenerateCircumstance(int dieValue)
        {
            foreach (IBirthCircumstanceProvider birthCircumstanceProvider in birthCircumstanceProviders)
            {
                if (birthCircumstanceProvider.IsWithinRange(dieValue))
                    return birthCircumstanceProvider.GetBirthCircumstance();
            }

            return null;
        }

        public CircumstanceOfBirth GenerateCircumstance()
        {
            return GenerateCircumstance(RandomDieGenerator.D100);
        }
    }
}

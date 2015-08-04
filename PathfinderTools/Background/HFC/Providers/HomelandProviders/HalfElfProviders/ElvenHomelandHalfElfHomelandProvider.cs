using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class ElvenHomelandHalfElfHomelandProvider : IHalfElfHomelandProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(1, 25, dieValue);
        }


        public Homeland GetHomeland()
        {
            Homeland homeland = new ElfHomelandTable().GenerateHomeland();

            if (homeland.HomelandType == BackgroundEnums.HomelandTypes.CityOrMetropolis)
            {
                homeland.Traits = new List<ITrait>()
                {
                    new CivilizedTrait(),
                    new FailedApprenticeTrait()
                };
            }
            else if (homeland.HomelandType == BackgroundEnums.HomelandTypes.TownOrVillage)
            {
                homeland.Traits = new List<ITrait>()
                {
                    new FailedApprenticeTrait()
                };
            }

            return homeland;
        }
    }
}

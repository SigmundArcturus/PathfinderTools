using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class HumanOrcHomelandProvider : IHalfOrcHomelandProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(61, 75, dieValue);
        }


        public Homeland GetHomeland()
        {
            Homeland homeland = new HumanHomelandTable().GenerateHomeland();
            if (homeland.HomelandType == BackgroundEnums.HomelandTypes.CityOrMetropolis)
            {
                homeland.Traits = new List<ITrait>()
                {
                    new BruteTrait(),
                    new VagabondChildTrait()
                };
            }
            return homeland;
        }
    }
}

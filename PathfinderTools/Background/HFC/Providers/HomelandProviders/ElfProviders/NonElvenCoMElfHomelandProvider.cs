using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class NonElvenCoMElfHomelandProvider : IElfHomelandProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(61, 80, dieValue);
        }


        public Homeland GetHomeland()
        {
            return new Homeland()
            {
                HomelandType = BackgroundEnums.HomelandTypes.CityOrMetropolis,
                Traits = new List<ITrait>()
                {
                    new CivilizedTrait(),
                    new ForlornTrait()
                }
            };
        }
    }
}

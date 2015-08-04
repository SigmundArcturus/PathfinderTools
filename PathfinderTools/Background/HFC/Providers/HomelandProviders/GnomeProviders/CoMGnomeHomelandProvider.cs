using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class CoMGnomeHomelandProvider : IGnomeHomelandProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(66, 95, dieValue);
        }


        public Homeland GetHomeland()
        {
            return new Homeland()
            {
                HomelandType = BackgroundEnums.HomelandTypes.CityOrMetropolis,
                Traits = new List<ITrait>()
                {
                    new RapscallionTrait()
                }
            };
        }
    }
}

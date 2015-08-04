using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class CoMHumanHomelandProvider : IHumanHomelandProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(51, 85, dieValue);
        }


        public Homeland GetHomeland()
        {
            return new Homeland()
            {
                HomelandType = BackgroundEnums.HomelandTypes.CityOrMetropolis,
                Traits = new List<ITrait>()
                {
                    new CivilizedTrait(),
                    new VagabondChildTrait()
                }
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class HillsOrMountainsDwarfHomelandProvider : IDwarfHomelandProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(1, 40, dieValue);
        }


        public Homeland GetHomeland()
        {
            return new Homeland()
            {
                HomelandType = BackgroundEnums.HomelandTypes.HillsOrMountains,
                Traits = new List<ITrait>()
                {
                    new HighlanderTrait(),
                    new GoldsnifferTrait()
                }
            };
        }
    }
}

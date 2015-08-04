using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class UndergroundDwarfHomelandProvider : IDwarfHomelandProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(41, 80, dieValue);
        }

        public Homeland GetHomeland()
        {
            return new Homeland()
            {
                HomelandType = BackgroundEnums.HomelandTypes.Underground,
                Traits = new List<ITrait>()
                {
                    new SurfaceStrangerTrait(),
                    new TunnelFighterTrait()
                }
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class SubterraneanHalfOrcHomelandProvider : IHalfOrcHomelandProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(1, 25, dieValue);
        }


        public Homeland GetHomeland()
        {
            return new Homeland()
            {
                HomelandType = BackgroundEnums.HomelandTypes.Subterranean,
                Traits = new List<ITrait>()
                {
                    new ScrapperTrait(),
                    new SurfaceStrangerTrait()
                }
            };
        }
    }
}

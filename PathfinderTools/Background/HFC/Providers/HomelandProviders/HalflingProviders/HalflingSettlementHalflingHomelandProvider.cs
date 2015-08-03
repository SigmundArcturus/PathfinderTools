using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal abstract class HalflingSettlementHalflingHomelandProvider : IHalflingHomelandProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(1, 50, dieValue);
        }


        public Homeland GetHomeland()
        {
            return new Homeland()
            {
                HomelandType = BackgroundEnums.HomelandTypes.HalflingSettlement,
                Traits = new List<ITrait>()
                {
                    new CivilizedTrait(),
                    new WellInformedTrait()
                }
            };
        }
    }
}

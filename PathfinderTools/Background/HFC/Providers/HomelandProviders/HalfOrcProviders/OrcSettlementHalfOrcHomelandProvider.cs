using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal abstract class OrcSettlementHalfOrcHomelandProvider : IHalfOrcHomelandProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(26, 60, dieValue);
        }


        public Homeland GetHomeland()
        {
            return new Homeland()
            {
                HomelandType = BackgroundEnums.HomelandTypes.OrcSettlement,
                Traits = new List<ITrait>()
                {
                    new ScrapperTrait(),
                }
            };
        }
    }
}

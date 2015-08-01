using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class TradespeopleParentsProfessionProvider : IParentsProfessionProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(56, 70, dieValue);
        }


        public ParentsProfession GetParentsProfession()
        {
            return new ParentsProfession()
            {
                Profression = BackgroundEnums.ParentsProfessionTypes.Tradespeople,
                Traits = new List<Enum>()
                {
                    Traits.socialTrats.Artisan,
                    Traits.socialTrats.LifeOfToil
                }
            };
        }
    }
}

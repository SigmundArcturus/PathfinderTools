using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class SlavesParentsProfessionProvider : IParentsProfessionProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(1, 5, dieValue);
        }


        public ParentsProfession GetParentsProfession()
        {
            return new ParentsProfession()
            {
                Profression = BackgroundEnums.ParentsProfessionTypes.Slaves,
                Traits = new List<Enum>()
                {
                    Traits.socialTrats.LifeOfToil
                }
            };
        }
    }
}

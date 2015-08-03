using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class SoldiersParentsProfessionProvider : IParentsProfessionProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(31, 34, dieValue);
        }


        public ParentsProfession GetParentsProfession()
        {
            return new ParentsProfession()
            {
                Profression = BackgroundEnums.ParentsProfessionTypes.Soldiers,
                Traits = new List<ITrait>()
                {
                    new TacticianTrait()
                }
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class ThievesParentsProfessionProvider : IParentsProfessionProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(38, 40, dieValue);
        }


        public ParentsProfession GetParentsProfession()
        {
            return new ParentsProfession()
            {
                Profression = BackgroundEnums.ParentsProfessionTypes.Thieves,
                Traits = new List<ITrait>()
                {
                    new ChildOfTheStreetsTrait()
                }
            };
        }
    }
}

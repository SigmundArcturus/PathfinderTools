using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class BothAliveHalfOrcParentsProvider : IHalfOrcParentsProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(1, 10, dieValue);
        }


        public Parents GetParents()
        {
            return new Parents()
            {
                ParentsState = BackgroundEnums.ParentTypes.MotherAlive,
                Description = "Both of your parents are alive."
            };
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class BothDeadHalflingParentsProvider : IHalflingParentsProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(91, 100, dieValue);
        }


        public Parents GetParents()
        {
            return new Parents()
            {
                ParentsState = BackgroundEnums.ParentTypes.BothDead,
                Traits = new List<Enum>()
                {
                    Traits.socialTrats.Orphaned
                },
                Description = "Both of your parents are dead"
            };
        }
    }
}

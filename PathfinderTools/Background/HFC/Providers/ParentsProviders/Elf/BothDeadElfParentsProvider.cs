﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class BothDeadElfParentsProvider : IElfParentsProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(96, 100, dieValue);
        }


        public Parents GetParents()
        {
            return new Parents()
            {
                ParentsState = BackgroundEnums.ParentTypes.BothDead,
                Traits = new List<ITrait>()
                {
                    new OrphanedTrait()
                },
                Description = "Both of your parents are dead"
            };
        }
    }
}

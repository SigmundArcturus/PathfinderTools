﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class FatherAliveGnomeParentsProvider : IGnomeParentsProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(91, 93, dieValue);
        }


        public Parents GetParents()
        {
            return new Parents()
            {
                ParentsState = BackgroundEnums.ParentTypes.FatherAlive,
                Description = "Only your father is alive."
            };
        }
    }
}

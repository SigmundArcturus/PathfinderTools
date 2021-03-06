﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class SerfsPeasantsParentsProfessionProvider : IParentsProfessionProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(6, 25, dieValue);
        }


        public ParentsProfession GetParentsProfession()
        {
            return new ParentsProfession()
            {
                Profression = BackgroundEnums.ParentsProfessionTypes.SerfsPeasants,
                Traits = new List<ITrait>()
                {
                    new PovertyStrickenTrait()
                }
            };
        }
    }
}

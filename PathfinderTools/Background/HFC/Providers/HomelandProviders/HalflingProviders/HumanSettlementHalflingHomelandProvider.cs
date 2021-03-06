﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal abstract class HumanSettlementHalflingHomelandProvider : IHalflingHomelandProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(51, 80, dieValue);
        }


        public Homeland GetHomeland()
        {
            return new Homeland()
            {
                HomelandType = BackgroundEnums.HomelandTypes.HumanSettlement,
                Traits = new List<ITrait>()
                {
                    new ChildOfTheStreetsTrait(),
                    new WellInformedTrait()
                }
            };
        }
    }
}

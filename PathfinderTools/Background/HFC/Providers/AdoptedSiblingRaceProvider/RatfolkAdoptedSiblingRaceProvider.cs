﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class RatfolkAdoptedSiblingRaceProvider : IAdoptedSiblingRaceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(89, 89, dieValue);
        }


        public BackgroundEnums.RaceTypes GetSiblingRace()
        {
            return BackgroundEnums.RaceTypes.Ratfolk;
        }
    }
}

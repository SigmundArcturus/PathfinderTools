﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class KitsuneAdoptedSiblingRaceProvider : IAdoptedSiblingRaceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(83, 83, dieValue);
        }


        public BackgroundEnums.RaceTypes GetSiblingRace()
        {
            return BackgroundEnums.RaceTypes.Kitsune;
        }
    }
}

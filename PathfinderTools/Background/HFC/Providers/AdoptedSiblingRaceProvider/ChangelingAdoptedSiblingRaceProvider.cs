﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class ChangelingAdoptedSiblingRaceProvider : IAdoptedSiblingRaceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(3, 4, dieValue);
        }


        public BackgroundEnums.RaceTypes GetSiblingRace()
        {
            return BackgroundEnums.RaceTypes.Changeling;
        }
    }
}

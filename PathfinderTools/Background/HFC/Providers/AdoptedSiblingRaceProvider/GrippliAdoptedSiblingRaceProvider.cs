﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class GrippliAdoptedSiblingRaceProvider : IAdoptedSiblingRaceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(40, 40, dieValue);
        }


        public BackgroundEnums.RaceTypes GetSiblingRace()
        {
            return BackgroundEnums.RaceTypes.Grippli;
        }
    }
}

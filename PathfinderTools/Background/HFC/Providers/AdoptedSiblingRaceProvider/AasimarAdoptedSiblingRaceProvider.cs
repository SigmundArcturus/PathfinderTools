﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class AasimarAdoptedSiblingRaceProvider : IAdoptedSiblingRaceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(1, 1, dieValue);
        }


        public Sibling GetSiblingRace(Sibling sibling)
        {
            sibling.Race = BackgroundEnums.RaceTypes.Aasimar;
            return sibling;
        }
    }
}

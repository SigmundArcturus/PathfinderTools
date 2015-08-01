﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public abstract class ElfRaceTraitBase : BaseRaceTrait
    {
        public override RaceTraitEnum RaceTraitType
        {
            get { return RaceTraitEnum.Elf; }
        }
    }
}
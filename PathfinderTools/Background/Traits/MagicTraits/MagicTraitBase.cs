﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public abstract class MagicTraitBase : ITrait
    {
        public TraitEnum TraitType
        {
            get
            {
                return TraitEnum.Magic;
            }
        }

        public abstract string Title { get; }

        public abstract string Description { get; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class TwinRelativeSiblingAgeProvider : IRelativeSiblingAgeProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(97, 100, dieValue);
        }

        public Sibling GetSiblingAge(Sibling sibling)
        {
            sibling.RelativeAge = BackgroundEnums.RelativeSiblingAge.Twin;
            return sibling;
        }
    }
}

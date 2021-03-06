﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class YoungerRelativeSiblingAgeProvider : IRelativeSiblingAgeProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(49, 96, dieValue);
        }

        public BackgroundEnums.RelativeSiblingAge GetSiblingAge()
        {
            return BackgroundEnums.RelativeSiblingAge.Younger;
        }
    }
}

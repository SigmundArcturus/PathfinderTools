﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class DamnedStoryFeat : IStoryFeats
    {
        public String Title
        {
            get
            {
                return "Damned (Story)";
            }
            internal set
            { }
        }
        public String Prerequisite { get; internal set; }
        public String Benefit { get; internal set; }
        public String Goal { get; internal set; }
        public String CompletionBenefit { get; internal set; }
    }
}

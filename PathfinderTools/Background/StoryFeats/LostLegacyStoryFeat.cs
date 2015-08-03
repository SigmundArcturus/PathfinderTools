using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class LostLegacyStoryFeat : IStoryFeats
    {
        public String Title
        {
            get
            {
                return "Lost Legacy (Story)";
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

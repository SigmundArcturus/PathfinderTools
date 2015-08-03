using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public interface IStoryFeats
    {
        String Title { get; }
        String Prerequisite { get; }
        String Benefit { get; }
        String Goal { get; }
        String CompletionBenefit { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    static public class RangeTool
    {
        static public bool WithinRange(int beginValue, int endValue, int actualValue)
        {
            if (beginValue <= actualValue && actualValue <= endValue) { return true; }
            return false;
        }
    }
}

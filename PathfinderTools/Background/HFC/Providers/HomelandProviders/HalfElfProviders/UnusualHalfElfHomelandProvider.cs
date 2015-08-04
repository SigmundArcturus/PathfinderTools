using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class UnusualHalfElfHomelandProvider : IHalfElfHomelandProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(96, 100, dieValue);
        }


        public Homeland GetHomeland()
        {
            return new UnusualHomelandTable().GenerateHomeland();
        }
    }
}

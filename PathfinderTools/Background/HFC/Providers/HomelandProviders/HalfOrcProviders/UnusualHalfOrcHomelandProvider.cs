using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal abstract class UnusualHalfOrcHomelandProvider : IHalfOrcHomelandProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(91, 100, dieValue);
        }


        public Homeland GetHomeland()
        {
            return new UnusualHomelandTable().GenerateHomeland();
        }
    }
}

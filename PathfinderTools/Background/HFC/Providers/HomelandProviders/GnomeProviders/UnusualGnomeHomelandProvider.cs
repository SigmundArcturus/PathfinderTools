using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class UnusualGnomeHomelandProvider : IGnomeHomelandProvider
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class GentryNobilityProvider : INobilityProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(01, 60, dieValue);
        }


        public Nobility GetNobility()
        {
            return new Nobility()
            {
                Title = "Gentry",
                Description = ""
            };
        }
    }
}

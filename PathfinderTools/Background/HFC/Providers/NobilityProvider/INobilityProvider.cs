using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal interface INobilityProvider
    {
        bool IsWithinRange(int dieValue);
        Nobility GetNobility();
    }
}

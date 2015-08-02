using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    interface IParentsProvider
    {
        bool IsWithinRange(int dieValue);
        Parents GetParents();
    }
}

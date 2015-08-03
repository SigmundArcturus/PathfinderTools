using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public abstract class RegionalTraitBase : ITrait
    {
        public abstract string Title { get; }

        public abstract string Description { get; }
    }
}

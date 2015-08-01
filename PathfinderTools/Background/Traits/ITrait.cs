using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public interface ITrait
    {
        TraitEnum TraitType { get; }
        String Title { get; }
        String Description { get; }
    }
}

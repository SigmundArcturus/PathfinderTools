using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public abstract class FaithTraitBase : ITrait
    {
        public TraitEnum TraitType { get { return TraitEnum.Faith; } }
        public abstract string Title { get; }
        public abstract string Description { get; }
    }
}
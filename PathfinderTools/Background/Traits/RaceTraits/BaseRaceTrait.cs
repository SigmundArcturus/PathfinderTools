using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public abstract class BaseRaceTrait : ITrait
    {
        public TraitEnum TraitType
        {
            get 
            {
                return TraitEnum.Race;
            }
        }

        public abstract RaceTraitEnum RaceTraitType { get; }

        public abstract string Title { get; }
        

        public abstract string Description { get; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class CircumstanceOfBirth
    {
        public BackgroundEnums.CircumstanceOfBirthTypes CircumstanceType;
        public List<ITrait> Traits = new List<ITrait>();
        public List<Enum> StoryFeats = new List<Enum>();
        public List<ParentsProfession> ParentsProfession = new List<ParentsProfession>();
        public BackgroundEnums.NobilityTypes NobilityType;
    }
}

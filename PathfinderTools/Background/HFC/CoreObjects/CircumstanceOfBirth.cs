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
        public List<IStoryFeats> StoryFeats = new List<IStoryFeats>();
    }
}

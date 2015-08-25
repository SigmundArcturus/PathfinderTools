using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pathfinder.Generators.Background;

namespace Pathfinder.Generators.Tests
{
    public class BirthCircumstanceTestObject
    {
        public BirthCircumstanceTestObject()
        {
            Traits = new List<ITrait>();
            StoryFeats = new List<IStoryFeats>();
        }

        public List<ITrait> Traits { get; set; }
        public BackgroundEnums.CircumstanceOfBirthTypes CircumstanceType { get; set; }
        public List<IStoryFeats> StoryFeats { get; set; }
    }
}

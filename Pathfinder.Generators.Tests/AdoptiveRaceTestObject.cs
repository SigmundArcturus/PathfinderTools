using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pathfinder.Generators.Background;

namespace Pathfinder.Generators.Tests
{
    public class AdoptiveRaceTestObject
    {
        public AdoptiveRaceTestObject()
        {
            Traits = new List<ITrait>();
            StoryFeats = new List<IStoryFeats>();
        }

        public List<ITrait> Traits { get; set; }
        public BackgroundEnums.AdoptedOutsideYourRaceTypes RaceType { get; set; }
        public List<IStoryFeats> StoryFeats { get; set; }
        public BackgroundEnums.RaceTypes CivilizedRace { get; set; }
    }
}

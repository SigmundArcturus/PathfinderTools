using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class AdoptiveRace
    {
        public AdoptiveRace()
        {
            Traits = new List<ITrait>();
            StoryFeats = new List<IStoryFeats>();
        }

        public List<ITrait> Traits { get; internal set; }
        public BackgroundEnums.AdoptedOutsideYourRaceTypes RaceType { get; set; }
        public List<IStoryFeats> StoryFeats { get; internal set; }
        public BackgroundEnums.RaceTypes CivilizedRace { get; set; }
    }
}

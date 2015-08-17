using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class CharacterInformation : IHFCCharacterInformation
    {
        public CharacterInformation()
        {
            Traits = new List<ITrait>();
            StoryFeats = new List<IStoryFeats>();
            ParentsProfessions = new List<ParentsProfession>();
        }

        public BackgroundEnums.RaceTypes Race { get; internal set; }

        public SiblingsList SiblingList { get; internal set; }

        public Homeland Homeland { get; internal set; }

        public CircumstanceOfBirth BirthCircumstance { get; internal set; }

        public List<ParentsProfession> ParentsProfessions { get; internal set; }

        public AdoptiveRace AdoptiveRace { get; internal set; }

        public Nobility Nobility { get; internal set; }

        public Parents Parents { get; internal set; }

        public List<ITrait> Traits { get; internal set; }

        public List<IStoryFeats> StoryFeats { get; internal set; }
    }
}

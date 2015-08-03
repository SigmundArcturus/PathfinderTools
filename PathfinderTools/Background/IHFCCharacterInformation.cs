using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public interface IHFCCharacterInformation
    {
        string Race { get; }
        SiblingsList SiblingList { get; }
        Homeland Homeland { get; }
        Parents Parents { get; }
        CircumstanceOfBirth BirthCircumstance { get; }
        List<ParentsProfession> ParentsProfessions { get; }
        AdoptiveRace AdoptiveRace { get; }
        Nobility Nobility { get; }
        List<ITrait> Traits { get; }
        List<IStoryFeats> StoryFeats { get; }
    }
}

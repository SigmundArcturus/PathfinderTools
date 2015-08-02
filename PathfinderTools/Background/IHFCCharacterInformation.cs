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
        List<Sibling> SiblingList {get; }
        Homeland Homeland { get; }
        CircumstanceOfBirth BirthCircumstance { get;  }
        ParentsProfession ParentsProfession { get; }
        AdoptiveRace AdoptiveRace { get;  }
        Nobility Nobility { get; }
    }
}

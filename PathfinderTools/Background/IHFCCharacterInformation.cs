using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public interface IHFCCharacterInformation
    {
        string GetRace();
        List<Sibling> GetSiblingList();
        Homeland GetHomeland();
        CircumstanceOfBirth GetBirthCircumstance();
        ParentsProfession GetParentsProfession();
        AdoptiveRace GetAdoptiveRace();
        Nobility GetNobility();
    }
}

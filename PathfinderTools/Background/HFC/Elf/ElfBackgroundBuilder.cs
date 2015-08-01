using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class ElfBackgroundBuilder : BaseBackgroundBuilder
    {
        public ElfBackgroundBuilder()
        {
            homelandTable = new ElfHomelandTable();
            parentsTable = new ElfParentsTable();
            siblingsTable = new ElfSiblingsTable();

            CharacterHomeland = homelandTable.GenerateHomeland();
            CharacterParents = parentsTable.GenerateParents();
            CharacterSiblings = siblingsTable.GenerateSiblings();

            generateCharacterTraits();
        }
    }
}

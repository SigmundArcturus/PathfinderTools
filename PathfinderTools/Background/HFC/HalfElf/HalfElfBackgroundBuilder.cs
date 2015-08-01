using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class HalfElfBackgroundBuilder : BaseBackgroundBuilder
    {
        public HalfElfBackgroundBuilder()
        {
            homelandTable = new HalfElfHomelandTable();
            parentsTable = new HalfElfParentsTable();
            siblingsTable = new HalfElfSiblingsTable();

            CharacterHomeland = homelandTable.GenerateHomeland();
            CharacterParents = parentsTable.GenerateParents();
            CharacterSiblings = siblingsTable.GenerateSiblings();

            generateCharacterTraits();
        }
    }
}

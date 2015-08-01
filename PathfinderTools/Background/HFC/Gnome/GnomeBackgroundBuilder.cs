using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class GnomeBackgroundBuilder : BaseBackgroundBuilder
    {
        public GnomeBackgroundBuilder()
        {
            homelandTable = new GnomeHomelandTable();
            parentsTable = new GnomeParentsTable();
            siblingsTable = new GnomeSiblingsTable();

            CharacterHomeland = homelandTable.GenerateHomeland();
            CharacterParents = parentsTable.GenerateParents();
            CharacterSiblings = siblingsTable.GenerateSiblings();

            generateCharacterTraits();
        }
    }
}

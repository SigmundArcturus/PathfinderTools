using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class DwarfBackgroundBuilder : BaseBackgroundBuilder
    {
        public DwarfBackgroundBuilder()
        {
            GenerateNewBackground();
        }

        public void GenerateNewBackground()
        {
            homelandTable = new DwarfHomelandTable();
            parentsTable = new DwarfParentsTable();
            siblingsTable = new DwarfSiblingsTable();

            characterHomeland = homelandTable.GenerateHomeland();
            CharacterParents = parentsTable.GenerateParents();
            characterSiblings = siblingsTable.GenerateSiblings();

            generateCharacterTraits();
        }
    }
}

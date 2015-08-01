using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class HalflingBackgroundBuilder : BaseBackgroundBuilder
    {
        public HalflingBackgroundBuilder()
        {
            GenerateNewBackground();
        }

        public void GenerateNewBackground()
        {
            homelandTable = new HalflingHomelandTable();
            parentsTable = new HalflingParentsTable();
            siblingsTable = new HalflingSiblingsTable();

            characterHomeland = homelandTable.GenerateHomeland();
            CharacterParents = parentsTable.GenerateParents();
            characterSiblings = siblingsTable.GenerateSiblings();

            generateCharacterTraits();
        }
    }
}

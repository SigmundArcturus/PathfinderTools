using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class HalfOrcBackgroundBuilder : BaseBackgroundBuilder
    {
        public HalfOrcBackgroundBuilder()
        {
            GenerateNewBackground();
        }

        public void GenerateNewBackground()
        {
            homelandTable = new HalfOrcHomelandTable();
            parentsTable = new HalfOrcParentsTable();
            siblingsTable = new HalfOrcSiblingsTable();

            characterHomeland = homelandTable.GenerateHomeland();
            CharacterParents = parentsTable.GenerateParents();
            characterSiblings = siblingsTable.GenerateSiblings();

            generateCharacterTraits();
        }
    }
}

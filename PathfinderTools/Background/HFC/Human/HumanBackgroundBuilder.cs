using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class HumanBackgroundBuilder : BaseBackgroundBuilder
    {
        public HumanBackgroundBuilder()
        {
            GenerateNewBackground();
        }

        public void GenerateNewBackground()
        {
            homelandTable = new HumanHomelandTable();
            parentsTable = new HumanParentsTable();
            siblingsTable = new HumanSiblingsTable();

            CharacterHomeland = homelandTable.GenerateHomeland();
            CharacterParents = parentsTable.GenerateParents();
            CharacterSiblings = siblingsTable.GenerateSiblings();

            generateCharacterTraits();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    class HalfElfSiblingsTable : ISiblingsTable
    {
        public SiblingsList GenerateSiblings(int dieValue)
        {
            SiblingsList siblings = new SiblingsList();
            Sibling sibling;
            int siblingCount;

            if (RangeTool.WithinRange(1, 20, dieValue))
            {
                siblingCount = RandomDieGenerator.D2;
                BackgroundEnums.RaceTypes siblingRace;
                if (RandomDieGenerator.D2 == 1) { siblingRace = BackgroundEnums.RaceTypes.Elf; } else { siblingRace = BackgroundEnums.RaceTypes.Human; }
                for (int i = 0; i < siblingCount; i++)
                {
                    sibling = new Sibling();
                    sibling.Race = siblingRace;
                    siblings.Siblings.Add(sibling);
                }
            }
            else if (RangeTool.WithinRange(21, 30, dieValue))
            {

                sibling = new Sibling();
                sibling.Race = BackgroundEnums.RaceTypes.HalfElf;
                siblings.Traits.Add(new KinBondTrait());
                siblings.Siblings.Add(sibling);
            }

            if (siblings.Siblings.Count() >= 1) { siblings.Traits.Add(new KinGuardianTrait()); }
            return siblings;
        }

        public SiblingsList GenerateSiblings()
        {
            return GenerateSiblings(RandomDieGenerator.D100);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    class ElfSiblingsTable : ISiblingsTable
    {
        public SiblingsList GenerateSiblings(int dieValue)
        {
            SiblingsList siblings = new SiblingsList();

            if (RangeTool.WithinRange(1, 80, dieValue))
            {
                int siblingCount = RandomDieGenerator.D2;

                for (int i = 0; i < siblingCount; i++)
                {
                    Sibling sibling = new Sibling();
                    sibling.Race = BackgroundEnums.RaceTypes.Elf;
                    sibling.RelativeAge = RelativeSiblingAgeTable.GenerateAge();
                    siblings.Siblings.Add(sibling);
                }
            }
            else if (RangeTool.WithinRange(81, 90, dieValue))
            {
                int siblingCount = RandomDieGenerator.D4 + 1;

                for (int i = 0; i < siblingCount; i++)
                {
                    Sibling sibling = new Sibling();
                    sibling.Race = BackgroundEnums.RaceTypes.Elf;
                    sibling.RelativeAge = RelativeSiblingAgeTable.GenerateAge();
                    siblings.Siblings.Add(sibling);
                }
            }
            else if (RangeTool.WithinRange(91, 95, dieValue))
            {
                int siblingCount = RandomDieGenerator.D4 + 1;
                int otherSiblingcount = RandomDieGenerator.D3 - 1;

                siblingCount = siblingCount - otherSiblingcount;

                for (int i = 0; i < siblingCount; i++)
                {
                    Sibling sibling = new Sibling();
                    sibling.Race = BackgroundEnums.RaceTypes.Elf;
                    sibling.RelativeAge = RelativeSiblingAgeTable.GenerateAge();
                    siblings.Siblings.Add(sibling);
                }

                for (int i = 0; i < otherSiblingcount; i++)
                {
                    Sibling sibling = new Sibling();
                    if (RandomDieGenerator.D2 == 1)
                    {
                        sibling.Race = BackgroundEnums.RaceTypes.HalfElf;
                        sibling.RelativeAge = RelativeSiblingAgeTable.GenerateAge();
                    }
                    else
                    {
                        sibling.Race = AdoptedSiblingRaceTable.GenerateRace();
                        sibling.RelativeAge = RelativeSiblingAgeTable.GenerateAge();
                        sibling.Adopted = true;
                    }
                    siblings.Siblings.Add(sibling);
                }
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

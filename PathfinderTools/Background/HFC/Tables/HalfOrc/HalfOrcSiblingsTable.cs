using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    class HalfOrcSiblingsTable : ISiblingsTable
    {
        public SiblingsList GenerateSiblings(int dieValue)
        {
            SiblingsList siblings = new SiblingsList();

            if (RangeTool.WithinRange(1, 60, dieValue))
            {
                int siblingCount = RandomDieGenerator.D6 + 1;

                for (int i = 0; i < siblingCount; i++)
                {
                    Sibling sibling = new Sibling();
                    sibling.Race = BackgroundEnums.RaceTypes.Orc;
                    sibling.RelativeAge = RelativeSiblingAgeTable.GenerateAge();
                    siblings.Siblings.Add(sibling);
                }
            }
            else if (RangeTool.WithinRange(61, 70, dieValue))
            {
                int siblingCount = RandomDieGenerator.D4;

                for (int i = 0; i < siblingCount; i++)
                {
                    Sibling sibling = new Sibling();
                    sibling.Race = BackgroundEnums.RaceTypes.Human;
                    sibling.RelativeAge = RelativeSiblingAgeTable.GenerateAge();
                    siblings.Siblings.Add(sibling);
                }
            }
            else if (RangeTool.WithinRange(71, 80, dieValue))
            {
                Sibling sibling = new Sibling();
                sibling.Race = BackgroundEnums.RaceTypes.HalfOrc;
                sibling.RelativeAge = RelativeSiblingAgeTable.GenerateAge();
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

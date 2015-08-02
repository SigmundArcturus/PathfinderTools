using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    class HumanSiblingsTable : ISiblingsTable
    {
        public SiblingsList GenerateSiblings(int dieValue)
        {
            SiblingsList siblings = new SiblingsList();

            if (RangeTool.WithinRange(1, 40, dieValue))
            {
                int siblingCount = RandomDieGenerator.D2;

                for (int i = 0; i < siblingCount; i++)
                {
                    Sibling sibling = new Sibling();
                    sibling.Race = BackgroundEnums.RaceTypes.Human;
                    sibling.RelativeAge = RelativeSiblingAgeTable.GenerateAge();
                    siblings.Siblings.Add(sibling);
                }
            }
            else if (RangeTool.WithinRange(41, 70, dieValue))
            {
                int siblingCount = RandomDieGenerator.D2;
                int halfSiblingCount = RandomDieGenerator.D2;

                for (int i = 0; i < siblingCount; i++)
                {
                    Sibling sibling = new Sibling();
                    sibling.Race = BackgroundEnums.RaceTypes.Human;
                    sibling.RelativeAge = RelativeSiblingAgeTable.GenerateAge();
                    siblings.Siblings.Add(sibling);
                }

                for (int i = 0; i < halfSiblingCount; i++)
                {
                    Sibling sibling = new Sibling();
                    int raceRoll = RandomDieGenerator.D100;

                    if (RangeTool.WithinRange(01, 50, raceRoll)) { sibling.Race = BackgroundEnums.RaceTypes.HalfElf; }
                    else { sibling.Race = BackgroundEnums.RaceTypes.HalfOrc; }

                    sibling.RelativeAge = RelativeSiblingAgeTable.GenerateAge();
                    siblings.Siblings.Add(sibling);
                }
            }
            else if (RangeTool.WithinRange(71, 90, dieValue))
            {
                int biologicalSiblings = (RandomDieGenerator.D4 + RandomDieGenerator.D4);

                for (int i = 0; i < biologicalSiblings; i++)
                {
                    Sibling sibling = new Sibling();
                    sibling.Race = BackgroundEnums.RaceTypes.Human;
                    sibling.RelativeAge = RelativeSiblingAgeTable.GenerateAge();
                    siblings.Siblings.Add(sibling);
                }
            }

            if (siblings.Siblings.Count() >= 1) { siblings.Traits.Add(Traits.combatTraits.KinGuardian); }
            return siblings;
        }

        public SiblingsList GenerateSiblings()
        {
            return GenerateSiblings(RandomDieGenerator.D100);
        }
    }
}

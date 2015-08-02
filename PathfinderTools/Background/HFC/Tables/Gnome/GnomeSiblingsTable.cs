using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    class GnomeSiblingsTable : ISiblingsTable
    {
        public SiblingsList GenerateSiblings(int dieValue)
        {
            SiblingsList siblings = new SiblingsList();
            Sibling sibling;
            int siblingCount;

            if (RangeTool.WithinRange(1, 50, dieValue))
            {
                siblingCount = RandomDieGenerator.D4;

                for (int i = 0; i < siblingCount; i++)
                {
                    sibling = new Sibling();
                    sibling.Race = BackgroundEnums.RaceTypes.Gnome;
                    sibling.RelativeAge = RelativeSiblingAgeTable.GenerateAge();
                    siblings.Siblings.Add(sibling);
                }
            }
            else if (RangeTool.WithinRange(51, 60, dieValue))
            {
                siblingCount = RandomDieGenerator.D4 - 1;

                for (int i = 0; i < siblingCount; i++)
                {
                    sibling = new Sibling();
                    sibling.Race = BackgroundEnums.RaceTypes.Gnome;
                    sibling.RelativeAge = RelativeSiblingAgeTable.GenerateAge();
                    siblings.Siblings.Add(sibling);
                }

                sibling = new Sibling();
                sibling.Adopted = true;
                sibling.Race = AdoptedSiblingRaceTable.GenerateRace();
                sibling.RelativeAge = RelativeSiblingAgeTable.GenerateAge();
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

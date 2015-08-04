using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public abstract class BaseBackgroundBuilder
    {
        private IHomelandTable homelandTable;
        private IParentsTable parentsTable;
        private ISiblingsTable siblingsTable;

        public BaseBackgroundBuilder(IHomelandTable homelandTable, IParentsTable parentsTable, ISiblingsTable siblingsTable)
        {
            this.homelandTable = homelandTable;
            this.parentsTable = parentsTable;
            this.siblingsTable = siblingsTable;
        }

        public CharacterInformation CreateBackground()
        {
            CharacterInformation characterInformation = new CharacterInformation();
            GenerateHomeland(characterInformation);
            GenerateParents(characterInformation);
            GenerateSiblings(characterInformation);
            GenerateCircumstancesOfBirth(characterInformation);

            return characterInformation;
        }

        protected void GenerateHomeland(CharacterInformation characterInformation)
        {
            characterInformation.Homeland = homelandTable.GenerateHomeland();
        }

        protected void GenerateSiblings(CharacterInformation characterInformation)
        {
            characterInformation.SiblingList = siblingsTable.GenerateSiblings();
        }

        protected void GenerateParents(CharacterInformation characterInformation)
        {
            characterInformation.Parents = parentsTable.GenerateParents();
        }

        protected void GenerateCircumstancesOfBirth(CharacterInformation characterInformation)
        {
            characterInformation.BirthCircumstance = new CircumstancesOfBirthTable().GenerateCircumstance();
            if (characterInformation.BirthCircumstance.CircumstanceType == BackgroundEnums.CircumstanceOfBirthTypes.AdoptedOutsideYourRace)
            {
                characterInformation.AdoptiveRace = AdoptedOutsideYourRaceTable.GenerateRace();
            }
            
            if (characterInformation.BirthCircumstance.CircumstanceType == BackgroundEnums.CircumstanceOfBirthTypes.NobleBirth)
            {
                characterInformation.Nobility = NobilityTable.GenerateNobility();
            }
            else if (characterInformation.BirthCircumstance.CircumstanceType == BackgroundEnums.CircumstanceOfBirthTypes.LowerClassBirth)
            {
                characterInformation.ParentsProfessions.Add(new ParentsProfessionTable().GenerateProfession(RandomDieGenerator.D20 + RandomDieGenerator.D20));
            }
            else
            {
                characterInformation.ParentsProfessions.Add(new ParentsProfessionTable().GenerateProfession());
            }
        }
    }
}

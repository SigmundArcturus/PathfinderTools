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
            SetTraits(characterInformation);
            SetStoryFeats(characterInformation);

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
            characterInformation.BirthCircumstance = CircumstancesOfBirthTable.GenerateCircumstance();
            if (characterInformation.BirthCircumstance.CircumstanceType == BackgroundEnums.CircumstanceOfBirthTypes.AdoptedOutsideYourRace)
            {
                characterInformation.AdoptiveRace = AdoptedOutsideYourRaceTable.GenerateRace();
            }
            
            if (characterInformation.BirthCircumstance != null && characterInformation.BirthCircumstance.CircumstanceType == BackgroundEnums.CircumstanceOfBirthTypes.NobleBirth)
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

            if (characterInformation.BirthCircumstance.CircumstanceType == BackgroundEnums.CircumstanceOfBirthTypes.Adopted)
            {
                characterInformation.ParentsProfessions.Add(new ParentsProfessionTable().GenerateProfession());
            }
        }

        protected void SetTraits(CharacterInformation characterInformation)
        {
            if (characterInformation.AdoptiveRace != null)
                GetTraits(characterInformation, characterInformation.AdoptiveRace.Traits);
            if (characterInformation.BirthCircumstance != null)
                GetTraits(characterInformation, characterInformation.BirthCircumstance.Traits);
            if (characterInformation.Homeland != null)
                GetTraits(characterInformation, characterInformation.Homeland.Traits);
            if (characterInformation.Parents != null)
                GetTraits(characterInformation, characterInformation.Parents.Traits);
            if (characterInformation.SiblingList != null)
                GetTraits(characterInformation, characterInformation.SiblingList.Traits);

            foreach (ParentsProfession profession in characterInformation.ParentsProfessions)
            {
                GetTraits(characterInformation, profession.Traits);
            }
        }

        protected void SetStoryFeats(CharacterInformation characterInformation)
        {
            if (characterInformation.AdoptiveRace != null)
                GetStoryFeats(characterInformation, characterInformation.AdoptiveRace.StoryFeats);
            if (characterInformation.BirthCircumstance != null)
                GetStoryFeats(characterInformation, characterInformation.BirthCircumstance.StoryFeats);
        }

        protected void GetTraits(CharacterInformation characterInformation, List<ITrait> traits)
        {
            foreach (ITrait trait in traits)
            {
                AddTraits(characterInformation, trait);
            }
        }

        protected void AddTraits(CharacterInformation characterInformation, ITrait trait)
        {
            foreach (ITrait characterTrait in characterInformation.Traits)
            {
                if (trait.Title == characterTrait.Title)
                    return;
            }

            characterInformation.Traits.Add(trait);
        }

        protected void GetStoryFeats(CharacterInformation characterInformation, List<IStoryFeats> feats)
        {
            foreach (IStoryFeats feat in feats )
            {
                AddStoryFeats(characterInformation, feat);
            }
        }

        protected void AddStoryFeats(CharacterInformation characterInformation, IStoryFeats feat)
        {
            foreach (IStoryFeats characterFeat in characterInformation.StoryFeats)
            {
                if (feat.Title == characterFeat.Title)
                    return;
            }

            characterInformation.StoryFeats.Add(feat);
        }
    }
}

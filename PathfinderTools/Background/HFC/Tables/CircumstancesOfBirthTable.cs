using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class CircumstancesOfBirthTable
    {
        public CircumstanceOfBirth GenerateCircumstance(int dieValue)
        {
            CircumstanceOfBirth circumstance = new CircumstanceOfBirth();
            ParentsProfessionTable parentsProfessionTable = new ParentsProfessionTable();

            if (RangeTool.WithinRange(1, 40, dieValue))
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.LowerClassBirth;
                circumstance.ParentsProfessions.Add(parentsProfessionTable.GenerateProfession(RandomDieGenerator.D20 + RandomDieGenerator.D20));
                circumstance.Traits.Add(new PovertyStrickenTrait());
            }
            else if (RangeTool.WithinRange(41, 65, dieValue))
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.MiddleClassBirth;
                circumstance.ParentsProfessions.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new ArtisanTrait());
                circumstance.Traits.Add(new MerchantTrait());
            }
            else if (RangeTool.WithinRange(66, 70, dieValue))
            {
                
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.NobleBirth;
                circumstance.Nobility = NobilityTable.GenerateNobility();
                circumstance.Traits.Add(new InfluenceTrait());
                circumstance.Traits.Add(new RichParentsTrait());
            }
            else if (RangeTool.WithinRange(71, 72, dieValue))
            {
                //
                //
                //
            }
            else if (RangeTool.WithinRange(73, 77, dieValue))
            {

                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.Adopted;
                circumstance.ParentsProfessions.Add(parentsProfessionTable.GenerateProfession());
                circumstance.ParentsProfessions.Add(parentsProfessionTable.GenerateProfession());
            }
            else if (RangeTool.WithinRange(78, 81, dieValue))
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.BastardBorn;
                circumstance.ParentsProfessions.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new BastardTrait());
                circumstance.StoryFeats.Add(new ShamedStoryFeat());
            }
            else if (dieValue == 82)
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.BlessedBirth;
                circumstance.ParentsProfessions.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new BlessedTrait());
                circumstance.Traits.Add(new BirthmarkTrait());
            }
            else if (RangeTool.WithinRange(82, 84, dieValue))
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.BornOfViolence;
                circumstance.ParentsProfessions.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new AxeToGrindTrait());
                circumstance.Traits.Add(new BastardTrait());
            }
            else if (dieValue == 85)
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.BornOutOfTime;
                circumstance.ParentsProfessions.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new ScholarOfTheGreatBeyondTrait());
            }
            else if (RangeTool.WithinRange(86, 87, dieValue))
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.BornIntoBondage;
                circumstance.ParentsProfessions.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new LifeOfToilTrait());
            }
            else if (dieValue == 88)
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.CursedBirth;
                circumstance.ParentsProfessions.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new FiendBloodTrait());
            }
            else if (RangeTool.WithinRange(88, 90, dieValue))
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.DishonoredFamily;
                circumstance.ParentsProfessions.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new ReactionaryTrait());
                circumstance.StoryFeats.Add(new LostLegacyStoryFeat());
                circumstance.StoryFeats.Add(new RedemptionStoryFeat());
            }
            else if (RangeTool.WithinRange(91, 92, dieValue))
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.HeirToALegacy;
                circumstance.ParentsProfessions.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new InfluenceTrait());
                circumstance.Traits.Add(new RichParentsTrait());
            }
            else if (RangeTool.WithinRange(93, 94, dieValue))
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.LeftToDie;
                circumstance.ParentsProfessions.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new CourageousTrait());
                circumstance.Traits.Add(new SavageTrait());
                circumstance.StoryFeats.Add(new ArisenStoryFeat());
            }
            else if (dieValue == 95)
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.MarkedByTheGods;
                circumstance.ParentsProfessions.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new BirthmarkTrait());
                circumstance.Traits.Add(new SacredTouchTrait());
                circumstance.StoryFeats.Add(new ProphetStoryFeat());
            }
            else if (dieValue == 96)
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.EnergyInfused;
                circumstance.ParentsProfessions.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new SacredConduitTrait());
                circumstance.Traits.Add(new SacredTouchTrait());
            }
            else if (dieValue == 97)
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.ProgenyOfPower;
                circumstance.ParentsProfessions.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new MagicalTalentTrait());
                circumstance.Traits.Add(new CharmingTrait());
                circumstance.Traits.Add(new SacredTouchTrait());
            }
            else if (dieValue == 98)
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.Prophesied;
                circumstance.ParentsProfessions.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new ProphesiedTrait());
            }
            else if (dieValue == 99)
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.Reincarnated;
                circumstance.ParentsProfessions.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new ReincarnatedTrait());
                circumstance.StoryFeats.Add(new ForgottenPastStoryFeat());
                circumstance.StoryFeats.Add(new ArisenStoryFeat());
            }
            else if (dieValue == 100)
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.TheOmen;
                circumstance.ParentsProfessions.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new OmenTrait());
            }

            return circumstance;
        }

        public CircumstanceOfBirth GenerateCircumstance()
        {
            return GenerateCircumstance(RandomDieGenerator.D100);
        }
    }
}

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
                circumstance.ParentsProfession.Add(parentsProfessionTable.GenerateProfession(RandomDieGenerator.D20 + RandomDieGenerator.D20));
                circumstance.Traits.Add(new PovertyStrickenTrait());
            }
            else if (RangeTool.WithinRange(41, 65, dieValue))
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.MiddleClassBirth;
                circumstance.ParentsProfession.Add(parentsProfessionTable.GenerateProfession());
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
                circumstance.ParentsProfession.Add(parentsProfessionTable.GenerateProfession());
                circumstance.ParentsProfession.Add(parentsProfessionTable.GenerateProfession());
            }
            else if (RangeTool.WithinRange(78, 81, dieValue))
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.BastardBorn;
                circumstance.ParentsProfession.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new BastardTrait());
                circumstance.StoryFeats.Add(BackgroundEnums.StoryFeats.Shamed);
            }
            else if (dieValue == 82)
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.BlessedBirth;
                circumstance.ParentsProfession.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new BlessedTrait());
                circumstance.Traits.Add(new BirthmarkTrait());
            }
            else if (RangeTool.WithinRange(82, 84, dieValue))
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.BornOfViolence;
                circumstance.ParentsProfession.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new AxeToGrindTrait());
                circumstance.Traits.Add(new BastardTrait());
            }
            else if (dieValue == 85)
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.BornOutOfTime;
                circumstance.ParentsProfession.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new ScholarOfTheGreatBeyondTrait());
            }
            else if (RangeTool.WithinRange(86, 87, dieValue))
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.BornIntoBondage;
                circumstance.ParentsProfession.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new LifeOfToilTrait());
            }
            else if (dieValue == 88)
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.CursedBirth;
                circumstance.ParentsProfession.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new FiendBloodTrait());
            }
            else if (RangeTool.WithinRange(88, 90, dieValue))
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.DishonoredFamily;
                circumstance.ParentsProfession.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new ReactionaryTrait());
                circumstance.StoryFeats.Add(BackgroundEnums.StoryFeats.LostLegacy);
                circumstance.StoryFeats.Add(BackgroundEnums.StoryFeats.Redemption);
            }
            else if (RangeTool.WithinRange(91, 92, dieValue))
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.HeirToALegacy;
                circumstance.ParentsProfession.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new InfluenceTrait());
                circumstance.Traits.Add(new RichParentsTrait());
            }
            else if (RangeTool.WithinRange(93, 94, dieValue))
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.LeftToDie;
                circumstance.ParentsProfession.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new CourageousTrait());
                circumstance.Traits.Add(new SavageTrait());
                circumstance.StoryFeats.Add(BackgroundEnums.StoryFeats.Arisen);
            }
            else if (dieValue == 95)
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.MarkedByTheGods;
                circumstance.ParentsProfession.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new BirthmarkTrait());
                circumstance.Traits.Add(new SacredTouchTrait());
                circumstance.StoryFeats.Add(BackgroundEnums.StoryFeats.Prophet);
            }
            else if (dieValue == 96)
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.EnergyInfused;
                circumstance.ParentsProfession.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new SacredConduitTrait());
                circumstance.Traits.Add(new SacredTouchTrait());
            }
            else if (dieValue == 97)
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.ProgenyOfPower;
                circumstance.ParentsProfession.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new MagicalTalentTrait());
                circumstance.Traits.Add(new CharmingTrait());
                circumstance.Traits.Add(new SacredTouchTrait());
            }
            else if (dieValue == 98)
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.Prophesied;
                circumstance.ParentsProfession.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new ProphesiedTrait());
            }
            else if (dieValue == 99)
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.Reincarnated;
                circumstance.ParentsProfession.Add(parentsProfessionTable.GenerateProfession());
                circumstance.Traits.Add(new ReincarnatedTrait());
                circumstance.StoryFeats.Add(BackgroundEnums.StoryFeats.ForgottenPast);
                circumstance.StoryFeats.Add(BackgroundEnums.StoryFeats.Arisen);
            }
            else if (dieValue == 100)
            {
                circumstance.CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.TheOmen;
                circumstance.ParentsProfession.Add(parentsProfessionTable.GenerateProfession());
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background{
    public static class BackgroundEnums
    {
        public enum HomelandTypes
        {
            HillsOrMountains, Underground, TownOrVillage, CityOrMetropolis, Forest, Subterranean, OrcSettlement, NoTrueHomeland,
            HalflingSettlement, HumanSettlement, TravelingBandOrCaravan, Frontier, Mountains, Plains, RiverSwampWetlands, Desert,
            Sea, Tundra, AnotherPlane
        };

        public enum RaceTypes
        {
            Aasimar, Catfolk, Changeling, Dhampir, Duergar, Dwarf, Elf, Fetchling, Gillman, Gnome, Goblin,
            Grippli, HalfElf, HalfOrc, Halfling, Hobgoblin, Human, Ifrit, Kitsune, Kobold, Merfolk, Nagaji, Orc, Oread, Ratfolk,
            Samsaran, Strix, Suli, Svirfneblin, Sylph, Tengu, Tiefling, Undine, Vanara, Vishkanya, Wayang
        };

        public enum RelativeSiblingAge
        {
            Older, Younger, Twin
        };

        public enum ParentTypes
        {
            BothAlive, FatherAlive, MotherAlive, BothDead
        };

        public enum CircumstanceOfBirthTypes
        {
            LowerClassBirth,
            MiddleClassBirth,
            NobleBirth,
            AdoptedOutsideYourRace,
            Adopted,
            BastardBorn,
            BlessedBirth,
            BornOfViolence,
            BornOutOfTime,
            BornIntoBondage,
            CursedBirth,
            DishonoredFamily,
            HeirToALegacy,
            LeftToDie,
            MarkedByTheGods,
            EnergyInfused,
            ProgenyOfPower,
            Prophesied,
            Reincarnated,
            TheOmen
        };

        public enum ParentsProfessionTypes
        {
            Slaves,
            SerfsPeasants,
            Entertainers,
            Soldiers,
            Sailors,
            Thieves,
            Yeomen,
            Tradespeople,
            Artisans,
            Merchants,
            ClergyOrCultists,
            Nobility
        };

        public enum AdoptedOutsideYourRaceTypes
        {
            AdoptedByDragons,
            AdoptedByTheFey,
            RaisedAmongTheDead,
            RaisedByAngels,
            RaisedByBeasts,
            RaisedByCivilizedHumanoids,
            RaisedBySavageHumanoids,
            FiendRaised
        };

        public enum NobilityTypes
        {
            Gentry,
            Knight,
            Baron,
            Count,
            Duke,
            MinorPrince,
            Regent
        };

        public enum MajorChildhoodEventTypes
        {
            AcademyTraining,
            Betrayal,
            Bullied,
            CompetitionChampion,
            DeathInTheFamily,
            Died,
            FallOfAMajorPower,
            FellInWithABadCrowd,
            FirstKill,
            TroubledFirstLove,
            Imprisoned,
            Inheritance,
            Kidnapped,
            MagicalGift,
            MajorDisaster,
            MentorshipPatronage,
            MetAFantasticCreature,
            OrdinaryChildhood,
            Raiders,
            TheWar
        };

        public enum CrimeTypes
        {
            Adultery,
            Arson,
            Burglary,
            Heresy,
            MinorOffense,
            Murder,
            RebellionTreason,
            Robbery,
            Smuggling,
            UnlawfulUseOfMagic
        };

        public enum PunishmentTypes
        {
            Beating,
            Branding,
            Exile,
            Fine,
            Imprisonment,
            Stocks,
            Torture,
            TrialByCombat,
            TrialByFire,
            TrialByWater
        }

        public enum FamilyTypes
        {
            BirthFamily,
            AdoptedFamily
        }

        public enum StoryFeats
        {
            Shamed,
            LostLegacy,
            Redemption,
            Arisen,
            Prophet,
            ForgottenPast,
            GlimpseBeyond,
            FeralHeart,
            Damned
        }
    }
}

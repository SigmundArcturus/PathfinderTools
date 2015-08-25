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
            HillsOrMountains = 1, Underground, TownOrVillage, CityOrMetropolis, Forest, Subterranean, OrcSettlement, NoTrueHomeland,
            HalflingSettlement, HumanSettlement, TravelingBandOrCaravan, Frontier, Mountains, Plains, RiverSwampWetlands, Desert,
            Sea, Tundra, AnotherPlane
        };

        public enum RaceTypes
        {
            Aasimar = 1, Catfolk, Changeling, Dhampir, Duergar, Dwarf, Elf, Fetchling, Gillman, Gnome, Goblin,
            Grippli, HalfElf, HalfOrc, Halfling, Hobgoblin, Human, Ifrit, Kitsune, Kobold, Merfolk, Nagaji, Orc, Oread, Ratfolk,
            Samsaran, Strix, Suli, Svirfneblin, Sylph, Tengu, Tiefling, Undine, Vanara, Vishkanya, Wayang
        };

        public enum SelectableRaceTypes
        {
            Dwarf = 1, Elf, Gnome, HalfElf, HalfOrc, Halfling, Human
        };

        public enum RelativeSiblingAge
        {
            Older = 1, Younger, Twin
        };

        public enum ParentTypes
        {
            BothAlive = 1, FatherAlive, MotherAlive, BothDead
        };

        public enum CircumstanceOfBirthTypes
        {
            LowerClassBirth = 1,
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
            Slaves = 1,
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
            AdoptedByDragons = 1,
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
            Gentry = 1,
            Knight,
            Baron,
            Count,
            Duke,
            MinorPrince,
            Regent
        };

        public enum MajorChildhoodEventTypes
        {
            AcademyTraining = 1,
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
            Adultery = 1,
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
            Beating = 1,
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
            BirthFamily = 1,
            AdoptedFamily
        }

        public enum StoryFeats
        {
            Shamed = 1,
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

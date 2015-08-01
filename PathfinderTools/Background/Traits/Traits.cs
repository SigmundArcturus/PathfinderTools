using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public static class Traits
    {
        public enum faithTraits
        {
            ScholarOfTheGreatBeyond,
            ChildOfTheTemple,
            Blessed,
            Birthmark,
            SacredTouch,
            SacredConduit,
            Prophesied,
            Reincarnated,
            Omen
        };

        public enum combatTraits
        {
            KinGuardian,
            Tactician,
            AxeToGrind,
            Reactionary,
            Courageous,
            Resilient
        };

        public enum magicTraits
        {
            KinBond,
            MagicalTalent,
            MagicalKnack
        };

        public enum raceTraits
        {
            TunnelFighter,
            Brewmaster,
            FailedApprentice,
            Forlorn,
            ElvenReflexes,
            AnimalFriend,
            Rapscallion,
            GoldSniffer,
            Scrapper,
            Brute,
            Outcast,
            WellInformed,
            FiendBlood,
            BloodOfDragons,
            Deathtouched,
            WarriorOfOld,
            FreedomFighter,
            AlmostHuman,
            ScholarOfTheRuins,
            WorldTraveler
        };

        public enum regionalTraits
        {
            Highlander,
            SurfaceStranger,
            MilitiaVeteran,
            VagabondChild,
            LogRoller,
            SavannaChild,
            RiverRat,
            DesertChild,
            Seasouled,
            TundraChild,
            FrontierForged
        };

        public enum socialTrats
        {
            Civilized,
            Orphaned,
            ChildOfTheStreets,
            FriendInEveryTown,
            LifeOfToil,
            PovertyStricken,
            Talented,
            Worldly,
            Artisan,
            Merchant,
            Influence,
            RichParents,
            Bastard,
            Savage,
            Charming
        };
    }
}

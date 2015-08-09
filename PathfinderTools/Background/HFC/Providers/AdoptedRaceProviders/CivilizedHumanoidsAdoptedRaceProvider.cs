using System;
using System.Collections.Generic;

namespace Pathfinder.Generators.Background.Providers
{
    internal class CivilizedHumanoidsAdoptedRaceProvider : IAdoptedRaceProvider
    {

        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(26, 70, dieValue);
        }

        public AdoptiveRace GetAdoptiveRace()
        {
            Random rnd = new Random();
            int race = rnd.Next(1, 8);

            if (race == 1)
            {
                return new AdoptiveRace()
                {
                    RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.RaisedByCivilizedHumanoids,
                    CivilizedRace = BackgroundEnums.RaceTypes.Dwarf,
                    Traits = new List<ITrait>()
                    {
                        new BrewmasterTrait(),
                        new GoldsnifferTrait(),
                        new TunnelFighterTrait()
                    }
                };
            }
            else if (race == 2)
            {
                return new AdoptiveRace()
                {
                    RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.RaisedByCivilizedHumanoids,
                    CivilizedRace = BackgroundEnums.RaceTypes.Elf,
                    Traits = new List<ITrait>()
                        {
                            new ForlornTrait(),
                            new WarriorOfOldTrait()
                        }
                };
            }
            else if (race == 3)
            {
                return new AdoptiveRace()
                {
                        RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.RaisedByCivilizedHumanoids,
                        CivilizedRace = BackgroundEnums.RaceTypes.Gnome,
                        Traits = new List<ITrait>()
                        {
                            new AnimalFriendTrait(),
                            new RapscallionTrait()
                        }
                };
            }
            else if (race == 4)
            {
                return new AdoptiveRace()
                {
                    RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.RaisedByCivilizedHumanoids,
                    CivilizedRace = BackgroundEnums.RaceTypes.HalfElf,
                    Traits = new List<ITrait>()
                    {
                        new ElvenReflexesTrait(),
                        new FailedApprenticeTrait()
                    }
                };
            }
            else if (race == 5)
            {
                return new AdoptiveRace()
                {
                    RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.RaisedByCivilizedHumanoids,
                    CivilizedRace = BackgroundEnums.RaceTypes.Halfling,
                    Traits = new List<ITrait>()
                    {
                        new FreedomFighterTrait(),
                        new WellInformedTrait()
                    }
                };
            }
            else if (race == 6)
            {
                return new AdoptiveRace()
                {
                    RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.RaisedByCivilizedHumanoids,
                    CivilizedRace = BackgroundEnums.RaceTypes.HalfOrc,
                    Traits = new List<ITrait>()
                    {
                        new AlmostHumanTrait(),
                        new BruteTrait(),
                        new OutcastTrait(),
                        new ScrapperTrait()
                    }
                };
            }
            else
            {
                return new AdoptiveRace()
                {
                    RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.RaisedByCivilizedHumanoids,
                    CivilizedRace = BackgroundEnums.RaceTypes.Human,
                    Traits = new List<ITrait>()
                    {
                        new ScholarOfRuinsTrait(),
                        new WorldTravelerTrait()
                    }
                };
            }
        }
    }
}


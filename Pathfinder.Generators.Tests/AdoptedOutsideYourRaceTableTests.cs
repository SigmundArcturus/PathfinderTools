﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Pathfinder.Generators.Background;
using System.Collections.Generic;

namespace Pathfinder.Generators.Tests
{
    [TestClass]
    public class AdoptedOutsideYourRaceTableTests : UnitTestBase
    {
        AdoptiveRace race;
        AdoptiveRaceTestObject expectedRace;

        [TestInitialize()]
        public void Initialize()
        {
            race = null;
            expectedRace = null;
        }

        [TestCleanup()]
        public void Cleanup()
        {
            race = null;
            expectedRace = null;
        }

        [TestMethod]
        public void BasicRetrievalTest()
        {
            race = AdoptedOutsideYourRaceTable.GenerateRace();

            Assert.IsNotNull(race);
        }

        [TestMethod]
        public void CompleteInBoundsTest()
        {
            for (int i = 1; i <= 100; i++)
            {
                race = AdoptedOutsideYourRaceTable.GenerateRace(i);
                Assert.IsNotNull(race);
            }
        }

        [TestMethod]
        public void BasicOutOfBoundsTest()
        {
            //Arange
            AdoptiveRace race;

            //Act
            race = AdoptedOutsideYourRaceTable.GenerateRace(101);
            //Assert
            Assert.IsNull(race);
        }

        [TestMethod]
        public void DragonAdoptedTest()
        {
            //Arange
            AdoptiveRace actualRace;
            expectedRace = new AdoptiveRaceTestObject()
            {
                RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.AdoptedByDragons,
                Traits = new List<ITrait>()
                {
                    new BloodOfDragonsTrait(),
                    new MagicalKnackTrait()
                }
            };

            //Act
            for (int i = 1; i <= 5; i++)
            {
                //Assert
                actualRace = AdoptedOutsideYourRaceTable.GenerateRace(i);
                AssertAdoptiveRace(expectedRace, actualRace);
            }
        }

        [TestMethod]
        public void FeyAdoptedTest()
        {
            //Arange
            AdoptiveRace actualRace;
            expectedRace = new AdoptiveRaceTestObject()
            {
                RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.AdoptedByTheFey,
                Traits = new List<ITrait>()
                {
                    new CharmingTrait(),
                    new MagicalKnackTrait()
                }
            };

            //Act
            for (int i = 6; i <= 10; i++)
            {
                //Assert
                actualRace = AdoptedOutsideYourRaceTable.GenerateRace(i);
                AssertAdoptiveRace(expectedRace, actualRace);
            }
        }

        [TestMethod]
        public void DeadAdoptedTest()
        {
            //Arange
            AdoptiveRace actualRace;
            expectedRace = new AdoptiveRaceTestObject()
            {
                RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.RaisedAmongTheDead,
                Traits = new List<ITrait>()
                {
                    new DeathtouchedTrait(),
                    new MagicalKnackTrait()
                },

                StoryFeats = new List<IStoryFeats>()
                {
                    new GlimpseBeyondStoryFeat()
                }
            };

            //Act
            for (int i = 11; i <= 13; i++)
            {
                //Assert
                actualRace = AdoptedOutsideYourRaceTable.GenerateRace(i);
                AssertAdoptiveRace(expectedRace, actualRace);
            }
        }

        [TestMethod]
        public void AngelAdoptedTest()
        {
            //Arange
            AdoptiveRace actualRace;
            expectedRace = new AdoptiveRaceTestObject()
            {
                RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.RaisedByAngels,
                Traits = new List<ITrait>()
                {
                    new BlessedTrait()
                }
            };

            //Act
            for (int i = 14; i <= 19; i++)
            {
                //Assert
                actualRace = AdoptedOutsideYourRaceTable.GenerateRace(i);
                AssertAdoptiveRace(expectedRace, actualRace);
            }
        }

        [TestMethod]
        public void BeastsAdoptedTest()
        {
            //Arange
            AdoptiveRace actualRace;
            expectedRace = new AdoptiveRaceTestObject()
            {
                RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.RaisedByBeasts,
                Traits = new List<ITrait>()
                {
                    new ResilientTrait()
                },

                StoryFeats = new List<IStoryFeats>()
                {
                    new FeralHeartStoryFeat()
                }
            };

            //Act
            for (int i = 20; i <= 25; i++)
            {
                //Assert
                actualRace = AdoptedOutsideYourRaceTable.GenerateRace(i);
                AssertAdoptiveRace(expectedRace, actualRace);
            }
        }

        [TestMethod]
        public void DwarfCivilizedHumanoidsAdoptedTest()
        {
            //Arange
            AdoptiveRace actualRace;
            expectedRace = new AdoptiveRaceTestObject()
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

            //Act
            for (int i = 26; i <= 70; i++)
            {
                //Assert
                do
                {
                    actualRace = AdoptedOutsideYourRaceTable.GenerateRace(i);
                } while (actualRace.CivilizedRace != BackgroundEnums.RaceTypes.Dwarf);
                AssertAdoptiveRace(expectedRace, actualRace);
            }
        }

        [TestMethod]
        public void ElfCivilizedHumanoidsAdoptedTest()
        {
            //Arange
            AdoptiveRace actualRace;
            expectedRace = new AdoptiveRaceTestObject()
            {
                RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.RaisedByCivilizedHumanoids,
                CivilizedRace = BackgroundEnums.RaceTypes.Elf,
                Traits = new List<ITrait>()
                {
                    new ForlornTrait(),
                    new WarriorOfOldTrait()
                }
            };

            //Act
            for (int i = 26; i <= 70; i++)
            {
                //Assert
                do
                {
                    actualRace = AdoptedOutsideYourRaceTable.GenerateRace(i);
                } while (actualRace.CivilizedRace != BackgroundEnums.RaceTypes.Elf);
                AssertAdoptiveRace(expectedRace, actualRace);
            }
        }

        [TestMethod]
        public void GnomeCivilizedHumanoidsAdoptedTest()
        {
            //Arange
            AdoptiveRace actualRace;
            expectedRace = new AdoptiveRaceTestObject()
            {
                RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.RaisedByCivilizedHumanoids,
                CivilizedRace = BackgroundEnums.RaceTypes.Gnome,
                Traits = new List<ITrait>()
                {
                    new AnimalFriendTrait(),
                    new RapscallionTrait()
                }
            };

            //Act
            for (int i = 26; i <= 70; i++)
            {
                //Assert
                do
                {
                    actualRace = AdoptedOutsideYourRaceTable.GenerateRace(i);
                } while (actualRace.CivilizedRace != BackgroundEnums.RaceTypes.Gnome);
                AssertAdoptiveRace(expectedRace, actualRace);
            }
        }

        [TestMethod]
        public void HalfElfCivilizedHumanoidsAdoptedTest()
        {
            //Arange
            AdoptiveRace actualRace;
            expectedRace = new AdoptiveRaceTestObject()
            {
                RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.RaisedByCivilizedHumanoids,
                CivilizedRace = BackgroundEnums.RaceTypes.HalfElf,
                Traits = new List<ITrait>()
                {
                    new ElvenReflexesTrait(),
                    new FailedApprenticeTrait()
                }
            };

            //Act
            for (int i = 26; i <= 70; i++)
            {
                //Assert
                do
                {
                    actualRace = AdoptedOutsideYourRaceTable.GenerateRace(i);
                } while (actualRace.CivilizedRace != BackgroundEnums.RaceTypes.HalfElf);
                AssertAdoptiveRace(expectedRace, actualRace);
            }
        }

        [TestMethod]
        public void HalflingCivilizedHumanoidsAdoptedTest()
        {
            //Arange
            AdoptiveRace actualRace;
            expectedRace = new AdoptiveRaceTestObject()
            {
                RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.RaisedByCivilizedHumanoids,
                CivilizedRace = BackgroundEnums.RaceTypes.Halfling,
                Traits = new List<ITrait>()
                {
                    new FreedomFighterTrait(),
                    new WellInformedTrait()
                }
            };

            //Act
            for (int i = 26; i <= 70; i++)
            {
                //Assert
                do
                {
                    actualRace = AdoptedOutsideYourRaceTable.GenerateRace(i);
                } while (actualRace.CivilizedRace != BackgroundEnums.RaceTypes.Halfling);
                AssertAdoptiveRace(expectedRace, actualRace);
            }
        }

        [TestMethod]
        public void HalfOrcCivilizedHumanoidsAdoptedTest()
        {
            //Arange
            AdoptiveRace actualRace;
            expectedRace = new AdoptiveRaceTestObject()
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

            //Act
            for (int i = 26; i <= 70; i++)
            {
                //Assert
                do
                {
                    actualRace = AdoptedOutsideYourRaceTable.GenerateRace(i);
                } while (actualRace.CivilizedRace != BackgroundEnums.RaceTypes.HalfOrc);
                AssertAdoptiveRace(expectedRace, actualRace);
            }
        }

        [TestMethod]
        public void HumanCivilizedHumanoidsAdoptedTest()
        {
            //Arange
            AdoptiveRace actualRace;
            expectedRace = new AdoptiveRaceTestObject()
            {
                RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.RaisedByCivilizedHumanoids,
                CivilizedRace = BackgroundEnums.RaceTypes.Human,
                Traits = new List<ITrait>()
                {
                    new ScholarOfRuinsTrait(),
                    new WorldTravelerTrait()
                }
            };

            //Act
            for (int i = 26; i <= 70; i++)
            {
                //Assert
                do
                {
                    actualRace = AdoptedOutsideYourRaceTable.GenerateRace(i);
                } while (actualRace.CivilizedRace != BackgroundEnums.RaceTypes.Human);
                AssertAdoptiveRace(expectedRace, actualRace);
            }
        }

        [TestMethod]
        public void SavageHumanoidAdoptedTest()
        {
            //Arange
            AdoptiveRace actualRace;
            expectedRace = new AdoptiveRaceTestObject()
            {
                RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.RaisedBySavageHumanoids,
                Traits = new List<ITrait>()
                {
                    new SavageTrait()
                },
            };

            //Act
            for (int i = 71; i <= 95; i++)
            {
                //Assert
                actualRace = AdoptedOutsideYourRaceTable.GenerateRace(i);
                AssertAdoptiveRace(expectedRace, actualRace);
            }
        }

        [TestMethod]
        public void FiendAdoptedTest()
        {
            //Arange
            AdoptiveRace actualRace;
            expectedRace = new AdoptiveRaceTestObject()
            {
                RaceType = BackgroundEnums.AdoptedOutsideYourRaceTypes.FiendRaised,
                Traits = new List<ITrait>()
                {
                    new FiendBloodTrait()
                },

                StoryFeats = new List<IStoryFeats>()
                {
                    new DamnedStoryFeat()
                }
            };

            //Act
            for (int i = 96; i <= 100; i++)
            {
                //Assert
                actualRace = AdoptedOutsideYourRaceTable.GenerateRace(i);
                AssertAdoptiveRace(expectedRace, actualRace);
            }
        }

        public void AssertAdoptiveRace(AdoptiveRaceTestObject expectedRace, AdoptiveRace actualRace)
        {

            Assert.AreEqual(actualRace.RaceType, expectedRace.RaceType, "Race Types are mismatched");
            AssertTraits(expectedRace.Traits, actualRace.Traits);
            AssertStoryFeats(expectedRace.StoryFeats, actualRace.StoryFeats);
            Assert.AreEqual(expectedRace.CivilizedRace, actualRace.CivilizedRace);

        }

    }
}

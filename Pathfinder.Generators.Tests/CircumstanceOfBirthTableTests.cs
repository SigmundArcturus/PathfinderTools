using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pathfinder.Generators.Background;
using System.Collections.Generic;

namespace Pathfinder.Generators.Tests
{
    [TestClass]
    public class CircumstanceOfBirthTableTests : UnitTestBase
    {
        [TestMethod]
        public void BasicRetrievalTest()
        {
            Assert.IsNotNull(CircumstancesOfBirthTable.GenerateCircumstance());
        }

        [TestMethod]
        public void BasicOutOfBoundsTest()
        {
            Assert.IsNull(CircumstancesOfBirthTable.GenerateCircumstance(101));
        }

        [TestMethod]
        public void CompleteInBoundsTest()
        {
            for (int i = 1; i <= 100; i++)
            {
                Assert.IsNotNull(CircumstancesOfBirthTable.GenerateCircumstance(i));
            }
        }

        [TestMethod]
        public void LowerClassBirthTest()
        {
            BirthCircumstanceTestObject testObject = new BirthCircumstanceTestObject()
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.LowerClassBirth,
                Traits = new List<ITrait>()
                {
                    new PovertyStrickenTrait()
                }
            };

            for (int i = 1; i <= 40; i++)
            {
                AssertBirthCircumstance(testObject, CircumstancesOfBirthTable.GenerateCircumstance(i));
            }
        }

        [TestMethod]
        public void MiddleClassBirthTest()
        {
            BirthCircumstanceTestObject testObject = new BirthCircumstanceTestObject()
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.MiddleClassBirth,
                Traits = new List<ITrait>()
                {
                    new ArtisanTrait(),
                    new MerchantTrait()
                }
            };

            for (int i = 41; i <= 65; i++)
            {
                AssertBirthCircumstance(testObject, CircumstancesOfBirthTable.GenerateCircumstance(i));
            }
        }

        [TestMethod]
        public void NobleBirthTest()
        {
            BirthCircumstanceTestObject testObject = new BirthCircumstanceTestObject()
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.NobleBirth,
                Traits = new List<ITrait>()
                {
                    new InfluenceTrait(),
                    new RichParentsTrait()
                }
            };

            for (int i = 66; i <= 70; i++)
            {
                AssertBirthCircumstance(testObject, CircumstancesOfBirthTable.GenerateCircumstance(i));
            }
        }

        [TestMethod]
        public void AdoptedOutsideRaceTest()
        {
            BirthCircumstanceTestObject testObject = new BirthCircumstanceTestObject()
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.AdoptedOutsideYourRace
            };

            for (int i = 71; i <= 72; i++)
            {
                AssertBirthCircumstance(testObject, CircumstancesOfBirthTable.GenerateCircumstance(i));
            }
        }

        [TestMethod]
        public void AdoptedTest()
        {
            BirthCircumstanceTestObject testObject = new BirthCircumstanceTestObject()
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.Adopted
            };

            for (int i = 73; i <= 77; i++)
            {
                AssertBirthCircumstance(testObject, CircumstancesOfBirthTable.GenerateCircumstance(i));
            }
        }

        [TestMethod]
        public void BastardBornTest()
        {
            BirthCircumstanceTestObject testObject = new BirthCircumstanceTestObject()
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.BastardBorn,
                Traits = new List<ITrait>()
                {
                    new BastardTrait()
                },
                StoryFeats = new List<IStoryFeats>()
                {
                    new ShamedStoryFeat()
                }
            };

            for (int i = 78; i <= 81; i++)
            {
                AssertBirthCircumstance(testObject, CircumstancesOfBirthTable.GenerateCircumstance(i));
            }
        }

        [TestMethod]
        public void BlessedBirthTest()
        {
            BirthCircumstanceTestObject testObject = new BirthCircumstanceTestObject()
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.BlessedBirth,
                Traits = new List<ITrait>()
                {
                    new BlessedTrait(),
                    new BirthmarkTrait()
                }
            };

            for (int i = 82; i <= 82; i++)
            {
                AssertBirthCircumstance(testObject, CircumstancesOfBirthTable.GenerateCircumstance(i));
            }
        }

        [TestMethod]
        public void BornOfViolenceTest()
        {
            BirthCircumstanceTestObject testObject = new BirthCircumstanceTestObject()
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.BornOfViolence,
                Traits = new List<ITrait>()
                {
                    new AxeToGrindTrait(),
                    new BastardTrait()
                }
            };

            for (int i = 83; i <= 84; i++)
            {
                AssertBirthCircumstance(testObject, CircumstancesOfBirthTable.GenerateCircumstance(i));
            }
        }

        [TestMethod]
        public void BornOutOfTimeTest()
        {
            BirthCircumstanceTestObject testObject = new BirthCircumstanceTestObject()
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.BornOutOfTime,
                Traits = new List<ITrait>()
                {
                    new ScholarOfTheGreatBeyondTrait()
                }
            };

            for (int i = 85; i <= 85; i++)
            {
                AssertBirthCircumstance(testObject, CircumstancesOfBirthTable.GenerateCircumstance(i));
            }
        }

        [TestMethod]
        public void BornIntoBondageTest()
        {
            BirthCircumstanceTestObject testObject = new BirthCircumstanceTestObject()
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.BornIntoBondage,
                Traits = new List<ITrait>()
                {
                    new LifeOfToilTrait()
                }
            };

            for (int i = 86; i <= 87; i++)
            {
                AssertBirthCircumstance(testObject, CircumstancesOfBirthTable.GenerateCircumstance(i));
            }
        }

        [TestMethod]
        public void CursedBirthTest()
        {
            BirthCircumstanceTestObject testObject = new BirthCircumstanceTestObject()
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.CursedBirth,
                Traits = new List<ITrait>()
                {
                    new FiendBloodTrait()
                },
                StoryFeats = new List<IStoryFeats>()
                {
                    new AccursedStoryFeat()
                }
            };

            for (int i = 88; i <= 88; i++)
            {
                AssertBirthCircumstance(testObject, CircumstancesOfBirthTable.GenerateCircumstance(i));
            }
        }

        [TestMethod]
        public void DishonoredFamilyTest()
        {
            BirthCircumstanceTestObject testObject = new BirthCircumstanceTestObject()
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.DishonoredFamily,
                Traits = new List<ITrait>()
                {
                    new ReactionaryTrait()
                },
                StoryFeats = new List<IStoryFeats>()
                {
                    new LostLegacyStoryFeat(),
                    new RedemptionStoryFeat()
                }
            };

            for (int i = 89; i <= 90; i++)
            {
                AssertBirthCircumstance(testObject, CircumstancesOfBirthTable.GenerateCircumstance(i));
            }
        }

        [TestMethod]
        public void HeirToALegacyTest()
        {
            BirthCircumstanceTestObject testObject = new BirthCircumstanceTestObject()
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.HeirToALegacy,
                Traits = new List<ITrait>()
                {
                    new InfluenceTrait(),
                    new RichParentsTrait()
                }
            };

            for (int i = 91; i <= 92; i++)
            {
                AssertBirthCircumstance(testObject, CircumstancesOfBirthTable.GenerateCircumstance(i));
            }
        }

        [TestMethod]
        public void LeftToDieTest()
        {
            BirthCircumstanceTestObject testObject = new BirthCircumstanceTestObject()
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.LeftToDie,
                Traits = new List<ITrait>()
                {
                    new CourageousTrait(),
                    new SavageTrait()
                },
                StoryFeats = new List<IStoryFeats>()
                {
                    new ArisenStoryFeat()
                }
            };

            for (int i = 93; i <= 94; i++)
            {
                AssertBirthCircumstance(testObject, CircumstancesOfBirthTable.GenerateCircumstance(i));
            }
        }

        [TestMethod]
        public void MarkedByTheGodsTest()
        {
            BirthCircumstanceTestObject testObject = new BirthCircumstanceTestObject()
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.MarkedByTheGods,
                Traits = new List<ITrait>()
                {
                    new BirthmarkTrait(),
                    new SacredTouchTrait()
                },
                StoryFeats = new List<IStoryFeats>()
                {
                    new ProphetStoryFeat()
                }
            };

            for (int i = 95; i <= 95; i++)
            {
                AssertBirthCircumstance(testObject, CircumstancesOfBirthTable.GenerateCircumstance(i));
            }
        }

        [TestMethod]
        public void EnergyInfusedTest()
        {
            BirthCircumstanceTestObject testObject = new BirthCircumstanceTestObject()
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.EnergyInfused,
                Traits = new List<ITrait>()
                {
                    new SacredTouchTrait(),
                    new SacredConduitTrait()
                }
            };

            for (int i = 96; i <= 96; i++)
            {
                AssertBirthCircumstance(testObject, CircumstancesOfBirthTable.GenerateCircumstance(i));
            }
        }

        [TestMethod]
        public void ProgenyOfPowerTest()
        {
            BirthCircumstanceTestObject testObject = new BirthCircumstanceTestObject()
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.ProgenyOfPower,
                Traits = new List<ITrait>()
                {
                    new MagicalTalentTrait(),
                    new CharmingTrait(),
                    new SacredTouchTrait()
                }
            };

            for (int i = 97; i <= 97; i++)
            {
                AssertBirthCircumstance(testObject, CircumstancesOfBirthTable.GenerateCircumstance(i));
            }
        }

        [TestMethod]
        public void ProphesiedTest()
        {
            BirthCircumstanceTestObject testObject = new BirthCircumstanceTestObject()
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.Prophesied,
                Traits = new List<ITrait>()
                {
                    new ProphesiedTrait()
                }
            };

            for (int i = 98; i <= 98; i++)
            {
                AssertBirthCircumstance(testObject, CircumstancesOfBirthTable.GenerateCircumstance(i));
            }
        }

        [TestMethod]
        public void ReincarnatedTest()
        {
            BirthCircumstanceTestObject testObject = new BirthCircumstanceTestObject()
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.Reincarnated,
                Traits = new List<ITrait>()
                {
                    new ReincarnatedTrait()
                },
                StoryFeats = new List<IStoryFeats>()
                {
                    new ArisenStoryFeat(),
                    new ForgottenPastStoryFeat()
                }
            };

            for (int i = 99; i <= 99; i++)
            {
                AssertBirthCircumstance(testObject, CircumstancesOfBirthTable.GenerateCircumstance(i));
            }
        }

        [TestMethod]
        public void OmenTest()
        {
            BirthCircumstanceTestObject testObject = new BirthCircumstanceTestObject()
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.TheOmen,
                Traits = new List<ITrait>()
                {
                    new OmenTrait()
                }
            };

            for (int i = 100; i <= 100; i++)
            {
                AssertBirthCircumstance(testObject, CircumstancesOfBirthTable.GenerateCircumstance(i));
            }
        }

        private void AssertBirthCircumstance(BirthCircumstanceTestObject expected, CircumstanceOfBirth actual)
        {
            Assert.AreEqual(expected.CircumstanceType, actual.CircumstanceType);
            AssertTraits(expected.Traits, actual.Traits);
            AssertStoryFeats(expected.StoryFeats, actual.StoryFeats);
        }
    }
}

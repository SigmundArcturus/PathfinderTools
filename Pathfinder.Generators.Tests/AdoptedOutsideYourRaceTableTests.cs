using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Pathfinder.Generators.Background;
using System.Collections.Generic;

namespace Pathfinder.Generators.Tests
{
    [TestClass]
    public class AdoptedOutsideYourRaceTableTests
    {
        [TestMethod]
        public void BasicRetrievalTest()
        {
            //Arange
            AdoptiveRace race;

            //Act
            race = AdoptedOutsideYourRaceTable.GenerateRace();
            //Assert
            Assert.IsNotNull(race);
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
            List<AdoptiveRace> raceList = new List<AdoptiveRace>();

            //Act
            for (int i = 1; i <= 5; i++)
            {
                raceList.Add(AdoptedOutsideYourRaceTable.GenerateRace(i));
            }

            //Assert
            foreach(AdoptiveRace race in raceList)
            {
                Assert.AreEqual(race.RaceType, BackgroundEnums.AdoptedOutsideYourRaceTypes.AdoptedByDragons);
                Assert.AreEqual(2, race.Traits.Count);
                Assert.IsTrue(TraitIsWithin(race.Traits, typeof(BloodOfDragonsTrait)));
                Assert.IsTrue(TraitIsWithin(race.Traits, typeof(MagicalKnackTrait)));
                Assert.AreEqual(0, race.StoryFeats.Count);
                Assert.AreEqual(0, (int)race.CivilizedRace);
            }
        }

        public bool TraitIsWithin(List<ITrait> traits, Type type)
        {
            foreach (ITrait characterTrait in traits)
            {
                if (type.Equals(characterTrait.GetType()))
                    return true;
            }

            return false;
        }

        public bool FeatIsWithin(List<IStoryFeats> feats, Type type)
        {
            foreach (IStoryFeats characterFeat in feats)
            {
                if (type.Equals(characterFeat.GetType()))
                    return true;
            }

            return false;
        }

    }
}

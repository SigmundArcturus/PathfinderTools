using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Pathfinder.Generators.Background;

namespace Pathfinder.Generators.Tests
{
    [TestClass]
    public class AdoptedSiblingRaceTableTests
    {
        BackgroundEnums.RaceTypes adoptedRaceType;

        [TestInitialize()]
        public void Initialize()
        {
            adoptedRaceType = 0;
        }

        [TestCleanup()]
        public void CleanUp()
        {
            adoptedRaceType = 0;
        }

        [TestMethod]
        public void BasicRetrievalTest()
        {
            adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(1);

            Assert.AreNotEqual(0, (int)adoptedRaceType);

        }

        [TestMethod]
        public void BasicOutOfBoundsTest()
        {
            adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(101);

            Assert.AreEqual(0, (int)adoptedRaceType);

        }

        [TestMethod]
        public void AasimarAdoptedSiblingRaceTest()
        {
            for (int i = 1; i <= 1; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Aasimar, adoptedRaceType);
            }
        }
    }
}
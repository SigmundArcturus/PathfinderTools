using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Pathfinder.Generators.Background;
using System.Diagnostics;

namespace Pathfinder.Generators.Tests
{
    [TestClass]
    public class AdoptedSiblingRaceTableTests : UnitTestBase
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
        public void CompleteInBoundsTest()
        {
            for (int i = 1; i <= 100; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Debug.WriteLine(i);
                Assert.AreNotEqual(0, (int)adoptedRaceType);
            }
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

        [TestMethod]
        public void CatfolkAdoptedSiblingRaceTest()
        {
            for (int i = 2; i <= 2; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Catfolk, adoptedRaceType);
            }
        }

        [TestMethod]
        public void ChangelingAdoptedSiblingRaceTest()
        {
            for (int i = 3; i <= 4; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Changeling, adoptedRaceType);
            }
        }

        [TestMethod]
        public void DhampirAdoptedSiblingRaceTest()
        {
            for (int i = 5; i <= 5; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Dhampir, adoptedRaceType);
            }
        }

        [TestMethod]
        public void DuergarAdoptedSiblingRaceTest()
        {
            for (int i = 6; i <= 6; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Duergar, adoptedRaceType);
            }
        }

        [TestMethod]
        public void DwarfAdoptedSiblingRaceTest()
        {
            for (int i = 7; i <= 16; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Dwarf, adoptedRaceType);
            }
        }

        [TestMethod]
        public void ElfAdoptedSiblingRaceTest()
        {
            for (int i = 17; i <= 26; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Elf, adoptedRaceType);
            }
        }

        [TestMethod]
        public void FetchlingAdoptedSiblingRaceTest()
        {
            for (int i = 27; i <= 27; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Fetchling, adoptedRaceType);
            }
        }

        [TestMethod]
        public void GillmanAdoptedSiblingRaceTest()
        {
            for (int i = 28; i <= 28; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Gillman, adoptedRaceType);
            }
        }

        [TestMethod]
        public void GnomeAdoptedSiblingRaceTest()
        {
            for (int i = 29; i <= 38; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Gnome, adoptedRaceType);
            }
        }

        [TestMethod]
        public void GoblinAdoptedSiblingRaceTest()
        {
            for (int i = 39; i <= 39; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Goblin, adoptedRaceType);
            }
        }

        [TestMethod]
        public void GrippliAdoptedSiblingRaceTest()
        {
            for (int i = 40; i <= 40; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Grippli, adoptedRaceType);
            }
        }

        [TestMethod]
        public void HalfElfAdoptedSiblingRaceTest()
        {
            for (int i = 41; i <= 50; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.HalfElf, adoptedRaceType);
            }
        }

        [TestMethod]
        public void HalfOrcAdoptedSiblingRaceTest()
        {
            for (int i = 51; i <= 60; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.HalfOrc, adoptedRaceType);
            }
        }

        [TestMethod]
        public void HalflingAdoptedSiblingRaceTest()
        {
            for (int i = 61; i <= 70; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Halfling, adoptedRaceType);
            }
        }

        [TestMethod]
        public void HobgoblinAdoptedSiblingRaceTest()
        {
            for (int i = 71; i <= 71; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Hobgoblin, adoptedRaceType);
            }
        }

        [TestMethod]
        public void HumanAdoptedSiblingRaceTest()
        {
            for (int i = 72; i <= 81; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Human, adoptedRaceType);
            }
        }

        [TestMethod]
        public void IfritAdoptedSiblingRaceTest()
        {
            for (int i = 82; i <= 82; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Ifrit, adoptedRaceType);
            }
        }

        [TestMethod]
        public void KitsuneAdoptedSiblingRaceTest()
        {
            for (int i = 83; i <= 83; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Kitsune, adoptedRaceType);
            }
        }

        [TestMethod]
        public void KoboldAdoptedSiblingRaceTest()
        {
            for (int i = 84; i <= 84; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Kobold, adoptedRaceType);
            }
        }

        [TestMethod]
        public void MerfolkAdoptedSiblingRaceTest()
        {
            for (int i = 85; i <= 85; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Merfolk, adoptedRaceType);
            }
        }

        [TestMethod]
        public void NagajiAdoptedSiblingRaceTest()
        {
            for (int i = 86; i <= 86; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Nagaji, adoptedRaceType);
            }
        }

        [TestMethod]
        public void OrcAdoptedSiblingRaceTest()
        {
            for (int i = 87; i <= 87; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Orc, adoptedRaceType);
            }
        }

        [TestMethod]
        public void OreadAdoptedSiblingRaceTest()
        {
            for (int i = 88; i <= 88; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Oread, adoptedRaceType);
            }
        }

        [TestMethod]
        public void RatfolkAdoptedSiblingRaceTest()
        {
            for (int i = 89; i <= 89; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Ratfolk, adoptedRaceType);
            }
        }

        [TestMethod]
        public void SamsaranAdoptedSiblingRaceTest()
        {
            for (int i = 90; i <= 90; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Samsaran, adoptedRaceType);
            }
        }

        [TestMethod]
        public void StrixAdoptedSiblingRaceTest()
        {
            for (int i = 91; i <= 91; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Strix, adoptedRaceType);
            }
        }

        [TestMethod]
        public void SuliAdoptedSiblingRaceTest()
        {
            for (int i = 92; i <= 92; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Suli, adoptedRaceType);
            }
        }

        [TestMethod]
        public void SvirfneblinAdoptedSiblingRaceTest()
        {
            for (int i = 93; i <= 93; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Svirfneblin, adoptedRaceType);
            }
        }

        [TestMethod]
        public void SylphAdoptedSiblingRaceTest()
        {
            for (int i = 94; i <= 94; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Sylph, adoptedRaceType);
            }
        }

        [TestMethod]
        public void TenguAdoptedSiblingRaceTest()
        {
            for (int i = 95; i <= 95; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Tengu, adoptedRaceType);
            }
        }

        [TestMethod]
        public void TieflingAdoptedSiblingRaceTest()
        {
            for (int i = 96; i <= 96; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Tiefling, adoptedRaceType);
            }
        }

        [TestMethod]
        public void UndineAdoptedSiblingRaceTest()
        {
            for (int i = 97; i <= 97; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Undine, adoptedRaceType);
            }
        }

        [TestMethod]
        public void VanaraAdoptedSiblingRaceTest()
        {
            for (int i = 98; i <= 98; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Vanara, adoptedRaceType);
            }
        }

        [TestMethod]
        public void VishkanyaAdoptedSiblingRaceTest()
        {
            for (int i = 99; i <= 99; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Vishkanya, adoptedRaceType);
            }
        }

        [TestMethod]
        public void WayangAdoptedSiblingRaceTest()
        {
            for (int i = 100; i <= 100; i++)
            {
                adoptedRaceType = AdoptedSiblingRaceTable.GenerateRace(i);
                Assert.AreEqual(BackgroundEnums.RaceTypes.Wayang, adoptedRaceType);
            }
        }
    }
}
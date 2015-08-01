using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    class AdoptedSiblingRaceTable
    {
        public static BackgroundEnums.RaceTypes GenerateRace(int dieValue)
        {
            if (1 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Aasimar;
            }
            else if (2 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Catfolk;
            }
            else if (RangeTool.WithinRange(3,4,dieValue))
            {
                return BackgroundEnums.RaceTypes.Changeling;
            }
            else if (5 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Dhampir;
            }
            else if (6 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Duergar;
            }
            else if (RangeTool.WithinRange(7, 16, dieValue))
            {
                return BackgroundEnums.RaceTypes.Dwarf;
            }
            else if (RangeTool.WithinRange(17, 26, dieValue))
            {
                return BackgroundEnums.RaceTypes.Elf;
            }
            else if (27 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Fetchling;
            }
            else if (28 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Gillman;
            }
            else if (RangeTool.WithinRange(29, 38, dieValue))
            {
                return BackgroundEnums.RaceTypes.Gnome;
            }
            else if (39 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Goblin;
            }
            else if (40 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Grippli;
            }
            else if (RangeTool.WithinRange(41,50, dieValue))
            {
                return BackgroundEnums.RaceTypes.HalfElf;
            }
            else if (RangeTool.WithinRange(51,60,dieValue))
            {
                return BackgroundEnums.RaceTypes.Halfling;
            }
            else if (RangeTool.WithinRange(61,70,dieValue))
            {
                return BackgroundEnums.RaceTypes.HalfOrc;
            }
            else if (71 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Hobgoblin;
            }
            else if (RangeTool.WithinRange(72,81,dieValue))
            {
                return BackgroundEnums.RaceTypes.Human;
            }
            else if (82 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Ifrit;
            }
            else if (83 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Kitsune;
            }
            else if (84 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Kobold;
            }
            else if (85 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Merfolk;
            }
            else if (86 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Nagaji;
            }
            else if (87 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Orc;
            }
            else if (88 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Oread;
            }
            else if (89 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Ratfolk;
            }
            else if (90 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Samsaran;
            }
            else if (91 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Strix;
            }
            else if (92 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Suli;
            }
            else if (93 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Svirfneblin;
            }
            else if (94 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Sylph;
            }
            else if (95 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Tengu;
            }
            else if (96 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Tiefling;
            }
            else if (97 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Undine;
            }
            else if (98 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Vanara;
            }
            else if (99 == dieValue)
            {
                return BackgroundEnums.RaceTypes.Vishkanya;
            }
            else
            {
                return BackgroundEnums.RaceTypes.Wayang;
            }
        }

        public static BackgroundEnums.RaceTypes GenerateRace() {
            return GenerateRace(RandomDieGenerator.D100);
        }
    }
}

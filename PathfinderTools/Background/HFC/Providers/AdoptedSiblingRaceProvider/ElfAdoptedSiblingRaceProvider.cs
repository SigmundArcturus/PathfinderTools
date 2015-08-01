using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class ElfAdoptedSiblingRaceProvider : IAdoptedSiblingRaceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(17, 26, dieValue);
        }


        public Sibling GetSiblingRace(Sibling sibling)
        {
            sibling.Race = BackgroundEnums.RaceTypes.Elf;
            return sibling;
        }
    }
}

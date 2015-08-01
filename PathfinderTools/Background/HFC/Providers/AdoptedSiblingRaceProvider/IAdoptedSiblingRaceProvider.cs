using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    interface IAdoptedSiblingRaceProvider
    {
        bool IsWithinRange(int dieValue);
        Sibling GetSiblingRace(Sibling sibling);
    }
}

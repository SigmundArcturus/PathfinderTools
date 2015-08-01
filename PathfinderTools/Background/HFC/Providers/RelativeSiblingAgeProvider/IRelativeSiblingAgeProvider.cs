using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    interface IRelativeSiblingAgeProvider
    {
        bool IsWithinRange(int dieValue);
        Sibling GetSiblingAge(Sibling sibling);
    }
}

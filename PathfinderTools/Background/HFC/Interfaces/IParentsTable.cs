using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public interface IParentsTable
    {
        Parents GenerateParents(int dieValue);
        Parents GenerateParents();
    }
}

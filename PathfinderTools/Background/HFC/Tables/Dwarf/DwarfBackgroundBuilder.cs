using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class DwarfBackgroundBuilder : BaseBackgroundBuilder
    {
        public DwarfBackgroundBuilder()
            : base (new DwarfHomelandTable(), new DwarfParentsTable(), new DwarfSiblingsTable())
        { }
    }
}

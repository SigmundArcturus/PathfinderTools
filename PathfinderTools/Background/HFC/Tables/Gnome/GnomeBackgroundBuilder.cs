using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class GnomeBackgroundBuilder : BaseBackgroundBuilder
    {
        public GnomeBackgroundBuilder()
            : base(new GnomeHomelandTable(), new GnomeParentsTable(), new GnomeSiblingsTable())
        { }
    }
}

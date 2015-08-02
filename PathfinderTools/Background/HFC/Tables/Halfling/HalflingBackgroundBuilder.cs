using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class HalflingBackgroundBuilder : BaseBackgroundBuilder
    {
        public HalflingBackgroundBuilder()
            : base(new HalflingHomelandTable(), new HalflingParentsTable(), new HalflingSiblingsTable())
        { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class HalfElfBackgroundBuilder : BaseBackgroundBuilder
    {
        public HalfElfBackgroundBuilder()
            : base(new HalfElfHomelandTable(), new HalfElfParentsTable(), new HalfElfSiblingsTable())
        { }
    }
}

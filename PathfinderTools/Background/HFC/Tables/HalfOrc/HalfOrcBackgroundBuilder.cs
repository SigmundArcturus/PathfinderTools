using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class HalfOrcBackgroundBuilder : BaseBackgroundBuilder
    {
        public HalfOrcBackgroundBuilder()
            : base(new HalfOrcHomelandTable(), new HalfOrcParentsTable(), new HalfOrcSiblingsTable())
        { }
    }
}

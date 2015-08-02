using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class HumanBackgroundBuilder : BaseBackgroundBuilder
    {
        public HumanBackgroundBuilder()
            : base(new HumanHomelandTable(), new HumanParentsTable(), new HumanSiblingsTable())
        { }
    }
}

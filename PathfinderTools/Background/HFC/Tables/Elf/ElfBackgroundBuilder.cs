using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class ElfBackgroundBuilder : BaseBackgroundBuilder
    {
        public ElfBackgroundBuilder()
            : base(new ElfHomelandTable(), new ElfParentsTable(), new ElfSiblingsTable())
        { }
    }
}

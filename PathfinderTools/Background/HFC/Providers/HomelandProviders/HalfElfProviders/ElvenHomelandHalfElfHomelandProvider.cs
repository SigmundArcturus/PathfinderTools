using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal abstract class ElvenHomelandHalfElfHomelandProvider : IHalfElfHomelandProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(1, 25, dieValue);
        }


        public Homeland GetHomeland()
        {
            ElfHomelandTable elfHomelandTable = new ElfHomelandTable();
            return null;
            //return elfHomelandTable.GenerateHomeland();
        }
    }
}

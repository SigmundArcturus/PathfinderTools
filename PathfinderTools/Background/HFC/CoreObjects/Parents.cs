using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class Parents
    {
        public BackgroundEnums.ParentTypes ParentsState;
        public string Description;
        public List<Enum> Traits = new List<Enum>();
    }
}

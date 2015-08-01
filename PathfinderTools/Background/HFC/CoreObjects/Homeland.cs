using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class Homeland
    {
        public BackgroundEnums.HomelandTypes HomelandType;
        public string Description;
        public List<Enum> Traits = new List<Enum>();
    }
}

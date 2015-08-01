using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class Nobility
    {
        public BackgroundEnums.NobilityTypes NobilityType { get; internal set; }
        public string Title { get; internal set; }
        public string Description { get; internal set; }
    }
}

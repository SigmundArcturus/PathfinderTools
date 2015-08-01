using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class OrphanedTrait : BaseSocialTrait
    {
        public override string Title
        {
            get
            {
                return "Orphaned";
            }
        }

        public override string Description
        {
            get
            {
                return "";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class CivilizedTrait : BaseSocialTrait
    {
        public override string Title
        {
            get
            {
                return "Civilized";
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

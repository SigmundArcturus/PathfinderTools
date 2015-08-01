using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class ScholarOfTheGreatBeyondTrait : FaithTraitBase
    {
        public override string Title
        {
            get
            {
                return "Scholar of the Great Beyond";
            }
        }

        public override string Description
        {
            get
            {
                return "Your greatest interests as a child did not lie with the current events or the mundane -- you have always felt out of place, " +
                    "as if you were born in the wrong era. You take to philosophical discussions of the Great Beyond and of historical events with ease. " +
                    "You gain a +1 trait bonus on Knowledge (History) and Knowledge (planes) checks, and one of these skills (your choice) is always a class " +
                    "skill for you.";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class AnatomistTrait : CombatTraitBase
    {
        public override string Title
        {
            get
            {
                return "Anatomist";
            }
        }

        public override string Description
        {
            get
            {
                return "You have studied the workings of anatomy, either as a student at university or as an apprentice mortician or necromancer. " +
                    "You know where to aim your blows to strike vital organs. you gain a +1 trait bonus on all rolls made to confirm critical hits.";
            }
        }
    }
}

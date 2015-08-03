using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal abstract class ForestGnomeHomelandProvider : IGnomeHomelandProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(1, 30, dieValue);
        }


        public Homeland GetHomeland()
        {
            return new Homeland()
            {
                HomelandType = BackgroundEnums.HomelandTypes.Forest,
                Traits = new List<ITrait>()
                {
                    new LogRollerTrait(),
                    new AnimalFriendTrait()
                }
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal abstract class TravelingBandHalflingHomelandProvider : IHalflingHomelandProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(81, 95, dieValue);
        }


        public Homeland GetHomeland()
        {
            return new Homeland()
            {
                HomelandType = BackgroundEnums.HomelandTypes.TravelingBandOrCaravan,
                Traits = new List<ITrait>()
                {
                    new FriendInEveryTownTrait()
                }
            };
        }
    }
}

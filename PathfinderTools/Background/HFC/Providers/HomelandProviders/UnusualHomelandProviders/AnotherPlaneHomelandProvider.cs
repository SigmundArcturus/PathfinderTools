using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal abstract class AnotherPlaneHomelandProvider : IUnusualHomelandProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(96, 100, dieValue);
        }


        public Homeland GetHomeland()
        {
            return new Homeland()
            {
                HomelandType = BackgroundEnums.HomelandTypes.AnotherPlane,
                Traits = new List<ITrait>()
                {
                    new ScholarOfTheGreatBeyondTrait()
                }
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal abstract class NoTrueHalfOrcHomelandProvider : IHalfOrcHomelandProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(76, 91, dieValue);
        }


        public Homeland GetHomeland()
        {
            return new Homeland()
            {
                HomelandType = BackgroundEnums.HomelandTypes.NoTrueHomeland,
                Traits = new List<ITrait>()
                {
                    new OutcastTrait()
                }
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    class RelativeSiblingAgeTable
    {
        public static BackgroundEnums.RelativeSiblingAge GenerateAge(int dieValue)
        {
            if (RangeTool.WithinRange(1, 48, dieValue))
            {
                return BackgroundEnums.RelativeSiblingAge.Older;
            }
            else if (RangeTool.WithinRange(49, 96, dieValue))
            {
                return BackgroundEnums.RelativeSiblingAge.Younger;
            }
            else
            {
                return BackgroundEnums.RelativeSiblingAge.Twin;
            }
        }

        public static BackgroundEnums.RelativeSiblingAge GenerateAge()
        {
            return GenerateAge(RandomDieGenerator.D100);
        }
    }
}

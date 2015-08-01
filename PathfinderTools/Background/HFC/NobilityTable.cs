using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    static class NobilityTable
    {
        static public BackgroundEnums.NobilityTypes GenerateNobility(int dieValue)
        {
            if (RangeTool.WithinRange(1, 60, dieValue))
            {
                return BackgroundEnums.NobilityTypes.Gentry;
            }
            else if (RangeTool.WithinRange(61, 78, dieValue))
            {
                return BackgroundEnums.NobilityTypes.Knight;
            }
            else if (RangeTool.WithinRange(79, 85, dieValue))
            {
                return BackgroundEnums.NobilityTypes.Baron;
            }
            else if (RangeTool.WithinRange(86, 91, dieValue))
            {
                return BackgroundEnums.NobilityTypes.Count;
            }
            else if (RangeTool.WithinRange(92, 96, dieValue))
            {
                return BackgroundEnums.NobilityTypes.Duke;
            }
            else if (RangeTool.WithinRange(97, 99, dieValue))
            {
                return BackgroundEnums.NobilityTypes.MinorPrince;
            }
            else
            {
                return BackgroundEnums.NobilityTypes.Regent;
            }
        }

        static public BackgroundEnums.NobilityTypes GenerateNobility()
        {
            return GenerateNobility(RandomDieGenerator.D100);
        }
    }
}

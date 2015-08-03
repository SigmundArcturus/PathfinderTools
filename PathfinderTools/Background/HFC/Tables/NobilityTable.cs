using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    static class NobilityTable
    {
        static public Nobility GenerateNobility(int dieValue)
        {
            if (RangeTool.WithinRange(1, 60, dieValue))
            {
                return new Nobility() 
                {
                };
            }
            else if (RangeTool.WithinRange(61, 78, dieValue))
            {
                return new Nobility()
                {
                };
            }
            else if (RangeTool.WithinRange(79, 85, dieValue))
            {
                return new Nobility()
                {
                };
            }
            else if (RangeTool.WithinRange(86, 91, dieValue))
            {
                return new Nobility()
                {
                };
            }
            else if (RangeTool.WithinRange(92, 96, dieValue))
            {
                return new Nobility()
                {
                };
            }
            else if (RangeTool.WithinRange(97, 99, dieValue))
            {
                return new Nobility()
                {
                };
            }
            else
            {
                return new Nobility()
                {
                };
            }
        }

        static public Nobility GenerateNobility()
        {
            return GenerateNobility(RandomDieGenerator.D100);
        }
    }
}

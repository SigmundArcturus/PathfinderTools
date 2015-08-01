using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class HalfElfParentsTable : IParentsTable
    {
        public Parents GenerateParents(int dieValue)
        {
            Parents parents = new Parents();

            if (RangeTool.WithinRange(1, 20, dieValue))
            {
                parents.ParentsState = BackgroundEnums.ParentTypes.BothAlive;
                parents.Description = "Both of your parents are alive";
            }
            else if (RangeTool.WithinRange(21, 55, dieValue))
            {
                parents.ParentsState = BackgroundEnums.ParentTypes.FatherAlive;
                parents.Description = "Only your father is alive";
            }
            else if (RangeTool.WithinRange(56, 90, dieValue))
            {
                parents.ParentsState = BackgroundEnums.ParentTypes.MotherAlive;
                parents.Description = "Only your mother is alive";
            }
            else
            {
                parents.ParentsState = BackgroundEnums.ParentTypes.BothDead;
                parents.Description = "Both of your parents are dead. You gain access to the Orphaned social trait";
                parents.Traits.Add(Traits.socialTrats.Orphaned);
            }

            return parents;
        }

        public Parents GenerateParents()
        {
            return GenerateParents(RandomDieGenerator.D100);
        }
    }
}

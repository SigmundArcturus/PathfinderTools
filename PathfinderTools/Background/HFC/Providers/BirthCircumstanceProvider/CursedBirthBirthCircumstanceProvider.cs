using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class CursedBirthBirthCircumstanceProvider : IBirthCircumstanceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(88, 88, dieValue);
        }


        public CircumstanceOfBirth GetBirthCircumstance()
        {
            return new CircumstanceOfBirth() 
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.CursedBirth,
                Traits = new List<ITrait>()
                {
                    new FiendBloodTrait()
                },
                StoryFeats = new List<IStoryFeats>()
                {
                    new AccursedStoryFeat()
                }
            };
        }
    }
}

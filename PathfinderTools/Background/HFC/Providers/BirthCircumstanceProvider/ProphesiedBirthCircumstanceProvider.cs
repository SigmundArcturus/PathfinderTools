using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class ProphesiedBirthCircumstanceProvider : IBirthCircumstanceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(98, 98, dieValue);
        }


        public CircumstanceOfBirth GetBirthCircumstance()
        {
            return new CircumstanceOfBirth() 
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.Prophesied,
                Traits = new List<ITrait>()
                {
                    new ProphesiedTrait()

                },
                StoryFeats = new List<IStoryFeats>()
                {
                }
            };
        }
    }
}

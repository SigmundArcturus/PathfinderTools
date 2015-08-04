using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class BastardBornBirthCircumstanceProvider : IBirthCircumstanceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(78, 81, dieValue);
        }


        public CircumstanceOfBirth GetBirthCircumstance()
        {
            return new CircumstanceOfBirth() 
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.BastardBorn,
                Traits = new List<ITrait>()
                {
                    new BastardTrait()
                },
                StoryFeats = new List<IStoryFeats>()
                {
                    new ShamedStoryFeat()
                }
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class HeirToALegacyBirthCircumstanceProvider : IBirthCircumstanceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(91, 92, dieValue);
        }


        public CircumstanceOfBirth GetBirthCircumstance()
        {
            return new CircumstanceOfBirth() 
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.HeirToALegacy,
                Traits = new List<ITrait>()
                {
                    new InfluenceTrait(),
                    new RichParentsTrait()
                },
                StoryFeats = new List<IStoryFeats>()
                {
                }
            };
        }
    }
}

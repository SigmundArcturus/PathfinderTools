using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class DishonoredFamilyBirthCircumstanceProvider : IBirthCircumstanceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(89, 90, dieValue);
        }


        public CircumstanceOfBirth GetBirthCircumstance()
        {
            return new CircumstanceOfBirth() 
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.DishonoredFamily,
                Traits = new List<ITrait>()
                {
                    new ReactionaryTrait()
                },
                StoryFeats = new List<IStoryFeats>()
                {
                    new LostLegacyStoryFeat(),
                    new RedemptionStoryFeat()
                }
            };
        }
    }
}

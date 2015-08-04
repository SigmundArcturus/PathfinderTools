using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class ReincarnatedBirthCircumstanceProvider : IBirthCircumstanceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(99, 99, dieValue);
        }


        public CircumstanceOfBirth GetBirthCircumstance()
        {
            return new CircumstanceOfBirth() 
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.Reincarnated,
                Traits = new List<ITrait>()
                {
                    new ReincarnatedTrait()

                },
                StoryFeats = new List<IStoryFeats>()
                {
                    new ForgottenPastStoryFeat(),
                    new ArisenStoryFeat()
                }
            };
        }
    }
}

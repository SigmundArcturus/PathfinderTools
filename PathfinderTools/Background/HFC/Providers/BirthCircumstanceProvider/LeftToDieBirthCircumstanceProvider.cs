using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class LeftToDieBirthCircumstanceProvider : IBirthCircumstanceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(93, 94, dieValue);
        }


        public CircumstanceOfBirth GetBirthCircumstance()
        {
            return new CircumstanceOfBirth() 
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.LeftToDie,
                Traits = new List<ITrait>()
                {
                    new CourageousTrait(),
                    new SavageTrait()
                },
                StoryFeats = new List<IStoryFeats>()
                {
                    new ArisenStoryFeat()
                }
            };
        }
    }
}

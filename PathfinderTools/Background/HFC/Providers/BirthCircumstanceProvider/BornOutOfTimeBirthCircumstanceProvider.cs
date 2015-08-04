using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class BornOutOfTimeBirthCircumstanceProvider : IBirthCircumstanceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(85, 85, dieValue);
        }


        public CircumstanceOfBirth GetBirthCircumstance()
        {
            return new CircumstanceOfBirth() 
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.BornOutOfTime,
                Traits = new List<ITrait>()
                {
                    new ScholarOfTheGreatBeyondTrait()
                },
                StoryFeats = new List<IStoryFeats>()
                {
                }
            };
        }
    }
}

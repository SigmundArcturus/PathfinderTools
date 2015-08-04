using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class BlessedBirthBirthCircumstanceProvider : IBirthCircumstanceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(82, 82, dieValue);
        }


        public CircumstanceOfBirth GetBirthCircumstance()
        {
            return new CircumstanceOfBirth() 
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.BastardBorn,
                Traits = new List<ITrait>()
                {
                    new BlessedTrait(),
                    new BirthmarkTrait()
                },
                StoryFeats = new List<IStoryFeats>()
                {
                }
            };
        }
    }
}

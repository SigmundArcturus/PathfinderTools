using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class BornOfViolenceBirthCircumstanceProvider : IBirthCircumstanceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(83, 84, dieValue);
        }


        public CircumstanceOfBirth GetBirthCircumstance()
        {
            return new CircumstanceOfBirth() 
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.BornOfViolence,
                Traits = new List<ITrait>()
                {
                    new BastardTrait(),
                    new AxeToGrindTrait()
                },
                StoryFeats = new List<IStoryFeats>()
                {
                }
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class MarkedByTheGodsBirthCircumstanceProvider : IBirthCircumstanceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(95, 95, dieValue);
        }


        public CircumstanceOfBirth GetBirthCircumstance()
        {
            return new CircumstanceOfBirth() 
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.MarkedByTheGods,
                Traits = new List<ITrait>()
                {
                    new BirthmarkTrait(),
                    new SacredTouchTrait()

                },
                StoryFeats = new List<IStoryFeats>()
                {
                    new ProphetStoryFeat()
                }
            };
        }
    }
}

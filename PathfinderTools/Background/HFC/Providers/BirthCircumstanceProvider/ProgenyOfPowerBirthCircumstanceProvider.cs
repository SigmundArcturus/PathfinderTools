using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class ProgenyOfPowerBirthCircumstanceProvider : IBirthCircumstanceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(97, 97, dieValue);
        }


        public CircumstanceOfBirth GetBirthCircumstance()
        {
            return new CircumstanceOfBirth() 
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.ProgenyOfPower,
                Traits = new List<ITrait>()
                {
                    new MagicalTalentTrait(),
                    new CharmingTrait(),
                    new SacredTouchTrait()

                },
                StoryFeats = new List<IStoryFeats>()
                {
                }
            };
        }
    }
}

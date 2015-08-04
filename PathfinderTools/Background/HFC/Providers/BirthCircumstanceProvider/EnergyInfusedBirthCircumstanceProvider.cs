using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class EnergyInfusedBirthCircumstanceProvider : IBirthCircumstanceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(96, 96, dieValue);
        }


        public CircumstanceOfBirth GetBirthCircumstance()
        {
            return new CircumstanceOfBirth() 
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.EnergyInfused,
                Traits = new List<ITrait>()
                {
                    new SacredConduitTrait(),
                    new SacredTouchTrait()

                },
                StoryFeats = new List<IStoryFeats>()
                {
                }
            };
        }
    }
}

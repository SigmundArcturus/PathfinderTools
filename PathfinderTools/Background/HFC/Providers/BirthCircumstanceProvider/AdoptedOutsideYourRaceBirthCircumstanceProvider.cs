using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class AdoptedOutsideYourRaceBirthCircumstanceProvider : IBirthCircumstanceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(71, 72, dieValue);
        }


        public CircumstanceOfBirth GetBirthCircumstance()
        {
            return new CircumstanceOfBirth() 
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.AdoptedOutsideYourRace
            };
        }
    }
}

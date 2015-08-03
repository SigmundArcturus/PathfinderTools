using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class LowerClassBirthCircumstanceProvider : BirthCircumstanceProviderBase
    {
        public override bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(1, 40, dieValue);
        }


        public override CircumstanceOfBirth GetBirthCircumstance(CircumstanceOfBirth circumstance)
        {
            ParentsProfessionTable parentsProfessionTable = new ParentsProfessionTable();

            return new CircumstanceOfBirth() 
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.LowerClassBirth,
                ParentsProfessions = new List<ParentsProfession>() 
                {
                    GetParentsProfession(RandomDieGenerator.D20 + RandomDieGenerator.D20)
                },
                Traits = new List<ITrait>()
                {
                    new PovertyStrickenTrait()
                }
            };
        }
    }
}

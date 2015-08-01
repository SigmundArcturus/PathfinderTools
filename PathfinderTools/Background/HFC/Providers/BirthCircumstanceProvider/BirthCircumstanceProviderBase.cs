using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal abstract class BirthCircumstanceProviderBase : IBirthCircumstanceProvider
    {
        public abstract bool IsWithinRange(int dieValue);

        public abstract CircumstanceOfBirth GetBirthCircumstance(CircumstanceOfBirth circumstance);

        protected ParentsProfession GetParentsProfession(int dieValue)
        {
            ParentsProfessionTable parentsProfessionTable = new ParentsProfessionTable();
            return parentsProfessionTable.GenerateProfession(dieValue);
        }

    }
}

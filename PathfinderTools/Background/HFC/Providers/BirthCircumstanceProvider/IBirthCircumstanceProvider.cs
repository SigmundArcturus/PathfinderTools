using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    interface IBirthCircumstanceProvider
    {
        bool IsWithinRange(int dieValue);
        CircumstanceOfBirth GetBirthCircumstance(CircumstanceOfBirth circumstance);
    }
}

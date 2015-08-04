using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class NonDwarvenTorVDwarfHomelandProvider : IDwarfHomelandProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(81, 87, dieValue);
        }

        public Homeland GetHomeland()
        {
            return new Homeland()
            {
                HomelandType = BackgroundEnums.HomelandTypes.TownOrVillage,
                Traits = new List<ITrait>()
                {
                    new BrewmasterTrait(),
                    new MilitiaVeteranTrait()
                }
            };
        }
    }
}

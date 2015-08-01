using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    public class UnusualHomelandTable : IHomelandTable
    {
        public Homeland GenerateHomeland(int dieValue)
        {
            Homeland homeland = new Homeland();

            if (RangeTool.WithinRange(1, 10, dieValue))
            {
                homeland.HomelandType = BackgroundEnums.HomelandTypes.Subterranean;
                homeland.Description = "Subterranean: You gain access to the Surface Stranger regional trait";
            }
            else if (RangeTool.WithinRange(11, 25, dieValue))
            {
                homeland.HomelandType = BackgroundEnums.HomelandTypes.Mountains;
                homeland.Description = "Mountains: You gain access to the Highlander regional trait";
            }
            else if (RangeTool.WithinRange(26, 40, dieValue))
            {
                homeland.HomelandType = BackgroundEnums.HomelandTypes.Plains;
                homeland.Description = "Plains: You gain access to the Savanna Child regional trait";
            }
            else if (RangeTool.WithinRange(41, 50, dieValue))
            {
                homeland.HomelandType = BackgroundEnums.HomelandTypes.TownOrVillage;
                homeland.Description = "Town or Village: You gain access to the Militia Veteran regional trait";
            }
            else if (RangeTool.WithinRange(51, 60, dieValue))
            {
                homeland.HomelandType = BackgroundEnums.HomelandTypes.CityOrMetropolis;
                homeland.Description = "City or Metropolis: You gain access to the Civilized social trait and the Vagabond Child regional trait";
            }
            else if (RangeTool.WithinRange(61, 70, dieValue))
            {
                homeland.HomelandType = BackgroundEnums.HomelandTypes.Forest;
                homeland.Description = "Forest: You gain access to the Log roller regional trait";
            }
            else if (RangeTool.WithinRange(71, 80, dieValue))
            {
                homeland.HomelandType = BackgroundEnums.HomelandTypes.RiverSwampWetlands;
                homeland.Description = "River, Swamp, or Wetlands: You gain access to the River Rat regional trait";
            }
            else if (RangeTool.WithinRange(81, 85, dieValue))
            {
                homeland.HomelandType = BackgroundEnums.HomelandTypes.Desert;
                homeland.Description = "Desert: You gain access to the Desert Child regional trait";
            }
            else if (RangeTool.WithinRange(86, 90, dieValue))
            {
                homeland.HomelandType = BackgroundEnums.HomelandTypes.Sea;
                homeland.Description = "Sea: You gain access to the Sea-Souled regional trait";
            }
            else if (RangeTool.WithinRange(91, 95, dieValue))
            {
                homeland.HomelandType = BackgroundEnums.HomelandTypes.Tundra;
                homeland.Description = "Tundra: You gain access to the Tundra Child regional trait";
            }
            else if (RangeTool.WithinRange(96, 100, dieValue))
            {
                homeland.HomelandType = BackgroundEnums.HomelandTypes.AnotherPlane;
                homeland.Description = "Another Plane: Your GM chooses the plane. You gain access to the Scholar of the Great Beyond faith traith";
            }
            
            return homeland;
        }

        public Homeland GenerateHomeland()
        {
            return GenerateHomeland(RandomDieGenerator.D100);
        }
    }
}

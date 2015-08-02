using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using Pathfinder.Generators.Background.Providers;

namespace Pathfinder.Generators.Background
{
    class Program
    {
        static void Main(string[] args)
        {
            DwarfBackgroundBuilder dbb = new DwarfBackgroundBuilder();
            CharacterInformation charInfo = dbb.CreateBackground();

            string race = Console.ReadLine();
        }
    }
}

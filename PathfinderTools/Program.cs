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
            BaseBackgroundBuilder dbb = new HumanBackgroundBuilder();
            CharacterInformation charInfo = dbb.CreateBackground();
            Console.ReadLine();
        }
    }
}

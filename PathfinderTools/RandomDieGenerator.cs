using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background
{
    static class RandomDieGenerator
    {
        private static Random rnd = new Random();

        static public int D2
        {
            get
            {
                return rnd.Next(1, 3);
            }
        }

        static public int D3
        {
            get
            {
                return rnd.Next(1, 4);
            }
        }

        static public int D4
        {
            get
            {
                return rnd.Next(1, 5);
            }
        }
        
        static public int D6
        {
            get
            {
                return rnd.Next(1, 7);
            }
        }

        static public int D8
        {
            get
            {
                return rnd.Next(1, 9);
            }
        }

        static public int D10
        {
            get
            {
                return rnd.Next(1, 11);
            }
        }

        static public int D12
        {
            get
            {
                return rnd.Next(1, 13);
            }
        }

        static public int D20
        {
            get
            {
                return rnd.Next(1, 21);
            }
        }

        static public int D100
        {
            get
            {
                return rnd.Next(1, 101);
            }
        }
    }
}

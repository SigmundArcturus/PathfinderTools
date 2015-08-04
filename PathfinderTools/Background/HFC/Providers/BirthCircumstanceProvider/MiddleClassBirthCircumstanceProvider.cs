﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder.Generators.Background.Providers
{
    internal class MiddleClassBirthCircumstanceProvider : IBirthCircumstanceProvider
    {
        public bool IsWithinRange(int dieValue)
        {
            return RangeTool.WithinRange(41, 65, dieValue);
        }


        public CircumstanceOfBirth GetBirthCircumstance()
        {
            return new CircumstanceOfBirth() 
            {
                CircumstanceType = BackgroundEnums.CircumstanceOfBirthTypes.MiddleClassBirth,

                Traits = new List<ITrait>()
                {
                    new ArtisanTrait(),
                    new MerchantTrait()
                }
            };
        }
    }
}

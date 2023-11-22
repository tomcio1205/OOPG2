using LAB2.AbstractCommercialBuildings;
using LAB2.Constructions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.CommercialBuildings
{
    class CommercialBuilding : AbstractCommercialBuilding
    {
        public CommercialBuilding(float height, float width, int entrances, int humanCapacity, TypeOfMaterial buildMaterial, string businessType) : base(height, width, entrances, humanCapacity, buildMaterial, businessType)
        {
        }
        public override void OpenBusiness()
        {
            Console.WriteLine($"The {BusinessType} business is now open in the commercial building!");
        }
    }
}

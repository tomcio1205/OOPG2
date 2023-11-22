using LAB2.AbstractMaterials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.Materials
{
    class BrikMaterial : AbstractMaterial
    {
        public BrikMaterial()
        {
            MaterialCost = 100;
        }
        public override double CalculateMaterialCost()
        {
            return MaterialCost;
        }
    }
}

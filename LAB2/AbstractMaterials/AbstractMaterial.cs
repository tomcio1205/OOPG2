using LAB2.Constructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.AbstractMaterials
{
    abstract class AbstractMaterial : Construction
    {
        protected double MaterialCost;
        public abstract double CalculateMaterialCost();
    }

}

using LAB2.Constructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.BuildingsWrapper
{
    class BuildingWrapper
    {
        public Construction _construction { get; set; }

        public BuildingWrapper(Construction construction)
        {
            _construction = construction; 
        }

        public double GetWrappedSquareCost()
        {
            return _construction.GetSquareCost();
        }
    }
}

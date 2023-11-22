using LAB2.Constructions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.Constructions.Interfaces
{
    interface IConstructionInfo
    {
        float Height { get; }
        float Width { get; }
        int Entrances { get; }
        int HumanCapacity { get; }
        TypeOfMaterial BuildMaterial { get; }

        void DisplayConstructionInfo();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.Constructions.Models
{
    class CreateConstructionDto
    {
        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public TypeOfMaterial BuildMaterial { get; set; }
    }
}

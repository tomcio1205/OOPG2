using LAB2.Constructions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.Constructions
{
    class Construction
    {
        public Construction(float height, float width, int entrances,
            int humanCapacity, TypeOfMaterial buildMaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
            BuildMaterial = buildMaterial;
        }

        public Construction()
        {
            Height = 23;
            Width = 12;
            Entrances = 1;
            HumanCapacity = 1;
            BuildMaterial = TypeOfMaterial.Brik;
        }

        public Construction(CreateConstructionDto input)
        {
            Height = input.Height;
            Width = input.Width;    
            Entrances = input.Entrances;
            HumanCapacity = input.HumanCapacity;
            BuildMaterial = input.BuildMaterial;
        }

        private TypeOfMaterial _buildMaterial { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public TypeOfMaterial BuildMaterial
        {
            get
            {
                return _buildMaterial;
            }
            set 
            {
                _buildMaterial = value;
            }
        }
    }
}
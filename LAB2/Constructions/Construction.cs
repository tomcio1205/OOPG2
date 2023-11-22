using LAB2.AbstractMaterials;
using LAB2.Constructions.Interfaces;
using LAB2.Constructions.Models;
using LAB2.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.Constructions
{
    class Construction: ISquareCost, IConstructionInfo
    {
        public Construction(float height, float width, int entrances, int humanCapacity, TypeOfMaterial buildMaterial)
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
        private AbstractMaterial _material { get; set; }

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

        public double GetSquareCost()
        {
            InitializeMaterial();
            if (BuildMaterial == TypeOfMaterial.Brik)
            {
                return Width * Height * 0.9 *
                _material.CalculateMaterialCost();
            }
            if (BuildMaterial == TypeOfMaterial.Concrete)
            {
                return Width * Height * 0.9 *
                _material.CalculateMaterialCost();
            }
            if (BuildMaterial == TypeOfMaterial.Wood)
            {
                return Width * Height * 0.9 *
                _material.CalculateMaterialCost();
            }
            return 0;
        }

        public double CalculateSquareCost()
        {
            return GetSquareCost();
        }
        public void DisplayCostDetails()
        {
            Console.WriteLine($"Square cost details for the building:");
            Console.WriteLine($"Height: {Height}, Width: {Width}, Entrances: { Entrances}, Human Capacity: { HumanCapacity}, Build Material: { BuildMaterial}");
            Console.WriteLine($"Square Cost: {CalculateSquareCost()}");
        }

        public void DisplayConstructionInfo()
        {
            Console.WriteLine($"Construction information for the building: ");
            Console.WriteLine($"Height: {Height}, Width: {Width}, Entrances: { Entrances}, Human Capacity: { HumanCapacity}, Build Material: { BuildMaterial}");
        }

        private void InitializeMaterial()
        {
            switch (_buildMaterial)
            {
                case TypeOfMaterial.Brik:
                    _material = new BrikMaterial();
                    break;
                case TypeOfMaterial.Concrete:
                    _material = new ConcreteMaterial();
                    break;
                case TypeOfMaterial.Wood:
                    _material = new WoodMaterial();
                    break;
                default:
                    throw new ArgumentException("Invalid build material type");
            }
        }

    }
}
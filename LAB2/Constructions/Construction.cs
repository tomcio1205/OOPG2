﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.Constructions
{
    class Construction
    {
        public Construction(float height, float width, int entrances,
            int humanCapacity, string buildMaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
            _buildMaterial = buildMaterial;
        }

        private string _buildMaterial { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public string BuildMaterial
        {
            get
            {
                return _buildMaterial;
            }
            set {
                _buildMaterial = value;
            }
        }
    }
}
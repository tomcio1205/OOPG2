using LAB2.BuildingsWrapper;
using LAB2.CommercialBuildings;
using LAB2.Constructions;
using LAB2.Constructions.Models;
using LAB2.IndustrialHalls;
using LAB2.ResidentalBuildings;
using System;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            var constr = new Construction(32, 23, 3, 6, TypeOfMaterial.Brik);
            var constr2 = new Construction();
            var inputParam = new CreateConstructionDto()
            {
                Height = 23,
                Width = 12,
                Entrances = 1,
                HumanCapacity = 1,
                BuildMaterial = TypeOfMaterial.Brik
            };
                
            var constr3 = new Construction(inputParam);
            //Console.WriteLine(constr.BuildMaterial);
            //Console.WriteLine(constr2.BuildMaterial);
            //Console.WriteLine(constr2.Width);
            //Console.WriteLine(constr2.Height);
            //Console.WriteLine(constr3.BuildMaterial);
            //Console.WriteLine(constr3.GetSquareCost());

            var building = new ResidentalBuilding(2);
            var hall = new IndustrialHall();

            Console.WriteLine(building.BuildMaterial);
            Console.WriteLine(building.Width);
            Console.WriteLine(building.Height);

            Console.WriteLine(hall.BuildMaterial);
            Console.WriteLine(hall.Width);
            Console.WriteLine(hall.Height);

            var wrapper1 = new BuildingWrapper(building);
            var wrapper2 = new BuildingWrapper(hall);

            Console.WriteLine(wrapper1.GetWrappedSquareCost());
            Console.WriteLine(wrapper2.GetWrappedSquareCost());

            var commercial = new CommercialBuilding(32, 23, 3, 6, TypeOfMaterial.Brik, "ecommerce");
            commercial.OpenBusiness();
            commercial.DisplayCostDetails();
            commercial.DisplayConstructionInfo();
        }
    }
}

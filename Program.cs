using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building NSSBUILDING = new Building
            ("233 Avenue", "Joel")
            {
                Width = 60,
                Depth = 90,
                Stories = 3
            };

            Building NashvilleStad = new Building("455 Lane", "Elliot")
            {
                Width = 22,
                Depth = 11,
                Stories = 3
            };

            NSSBUILDING.Construct();
            NSSBUILDING.Purchase("JR");
            NashvilleStad.Construct();
            NashvilleStad.Purchase("Dan");

            // Console.WriteLine(NashvilleStad.Address);
            // Console.WriteLine("-------------");
            // Console.WriteLine($"Designed by {NashvilleStad.Designer}");
            // Console.WriteLine($"Constructed on {NashvilleStad.DateConstructed}");
            // Console.WriteLine($"Owned by {NashvilleStad.Owner}");
            // Console.WriteLine($"{NashvilleStad.Volume} cubic meters of space");

            // Console.WriteLine(NSSBUILDING.Address);
            // Console.WriteLine("-------------");
            // Console.WriteLine($"Designed by {NSSBUILDING.Designer}");
            // Console.WriteLine($"Constructed on {NSSBUILDING.DateConstructed}");
            // Console.WriteLine($"Owned by {NSSBUILDING.Owner}");
            // Console.WriteLine($"{NSSBUILDING.Volume} cubic meters of space");


            City Nashville = new City(1775){
                CityAddress = "Nashville Tn",
                Mayor = "John wark"
            
            };

            Nashville.AddBuilding(NSSBUILDING);

            Console.WriteLine("Buildings In Nashville");
        foreach(Building building in Nashville.ListOfBuildings ){
            
            Console.WriteLine(building.Address);
            Console.WriteLine("-------------");
            Console.WriteLine($"Designed by {building.Designer}");
            Console.WriteLine($"Constructed on {building.DateConstructed}");
            Console.WriteLine($"Owned by {building.Owner}");
            Console.WriteLine($"{building.Volume} cubic meters of space");


        }
           
        }
    }
}


/////Ready For Github//


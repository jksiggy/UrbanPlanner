using System;
using System.Collections.Generic;

namespace Planner {
    public class City
    {
        private int _established;

        public string CityAddress { get; set; }
        public string Mayor { get; set; }


         public List<Building> ListOfBuildings {get; set;} = new List<Building>();

        public City (int established){
            _established = established;
        }

        public void AddBuilding(Building building){
            ListOfBuildings.Add(building);
        }
    }
}
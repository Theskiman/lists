using System;
using System.Collections.Generic;


namespace test_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){
                "Mercury", 
                "Mars"
                };
                planetList.Add("Jupiter");
                planetList.Add("Saturn");
            List<string> lastPlanets = new List<string>(){
                "Uranus",
                "Neptune"
            };
        planetList.Insert(1, "Venus"); 
        planetList.Insert(3, "Earth");
        planetList.Add("Pluto");
            planetList.AddRange(lastPlanets);
            planetList.Remove("Pluto");
     List<string> gasPlanets = planetList.GetRange(4, 4);
     
            foreach(string planet in planetList){
                Console.WriteLine(planet);
            }
            foreach(string planet in gasPlanets){
                Console.WriteLine();
                Console.WriteLine(planet);
            }

        }
    }
}
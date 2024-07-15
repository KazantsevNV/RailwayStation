using RailwayStation.DI;
using RailwayStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ParksStats
{
    public class ParkInfoPrinter
    {
        private readonly IStation _station;

        public ParkInfoPrinter() 
        {
            _station = DIContainer.Instance.Get<IStation>();
        }

        public void PrintParksInfo()
        {
            _station.Parks.ForEach(park =>
            {
                Console.WriteLine(park);

                var points = GetAllPointsInPark(park);
                points.ForEach(point => Console.WriteLine($"    {point}"));
                Console.WriteLine("");
            });
        }

        private List<Point> GetAllPointsInPark(Park park) 
        {
            return park.Entityes.SelectMany(way => way.Entityes)
                                          .SelectMany(section => new List<Point> { section.FirstPoint, section.SecondPoint })
                                          .Distinct()
                                          .ToList();
        }
    }
}

using RailwayStation.Model;
using System;

namespace ParksStats
{
    public class ParkInfoPrinter
    {
        private readonly IStation station;

        public ParkInfoPrinter() {
            station = ModelDIContainer.Instance.Get<IStation>();
        }

        public void PrintParksInfo() {
            foreach (var park in station.Parks) {
                Console.WriteLine(park);

                var points = park.GetAllPoints();
                points.ForEach(point => Console.WriteLine($"    {point}"));
                Console.WriteLine("");
            }
        }
    }
}

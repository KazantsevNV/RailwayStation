using RailwayStation.DI;
using RailwayStation.Model;
using System;
using System.Linq;

namespace RailwayStation.PathFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pathFinder = new DijkstraPathFinder();
            while (true)
            {
                var startPoint = GetPoint("Введите ID начальной точки пути :");
                var endPoint = GetPoint("Введите ID конечной точки пути :");

                var shortestPath = pathFinder.GetFindShortestPath(startPoint, endPoint);

                if (shortestPath.IsNullOrEmpty())
                {
                    Console.WriteLine($"Пути от {startPoint} до {endPoint} не существует");
                }
                else
                {

                    Console.WriteLine($"Кратчайший путь от {startPoint} до {endPoint}: ");
                    foreach (var point in shortestPath)
                    {
                        Console.WriteLine(point);
                    }
                }
                Console.WriteLine("");
            }
        }

        private static Point GetPoint(string message) 
        {
            int pointId = GetPointID(message);

            Point point;
            try
            {
                point = DIContainer.Instance.Get<IStation>().Points.First(p => p.Id == pointId);
            }
            catch (InvalidOperationException) 
            {
                Console.WriteLine($"Точки с ID = {pointId} не существует");
                point = GetPoint(message);
            }

            return point;
        }

        private static int GetPointID(string message) 
        {
            Console.Write(message);
            int pointId;
            try
            {
                pointId = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine($"ID точки должен быть целым числом");
                pointId = GetPointID(message);
            }
            return pointId;
        }
    }
}

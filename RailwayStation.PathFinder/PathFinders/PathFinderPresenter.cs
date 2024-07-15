using RailwayStation.Model;
using System;
using System.Linq;

namespace RailwayStation.PathFinder
{
    public class PathFinderPresenter
    {
        private const string START_POINT_MESSAGE = "Введите ID начальной точки пути :";
        private const string END_POINT_MESSAGE = "Введите ID конечной точки пути :";
        private const string PATH_NOT_FOUND_MESSAGE = "Пути от {0} до {1} не существует";
        private const string SHORTEST_PATH_MESSAGE = "Кратчайший путь от {0} до {1}: ";
        private const string FORMAT_EXCEPTION_MESSAGE = "ID точки должен быть целым числом";
        private const string INVALID_OPERATION_EXCEPTION_MESSAGE = "Точки с ID = {0} не существует";

        private ShortestPathFinder _pathFinder = new ShortestPathFinder();

        public void Start() 
        {
            while (true)
            {
                var startPoint = GetPoint(START_POINT_MESSAGE);
                var endPoint = GetPoint(END_POINT_MESSAGE);

                var shortestPath = _pathFinder.GetFindShortestPath(startPoint, endPoint);

                if (shortestPath.IsNullOrEmpty())
                {
                    Console.WriteLine(string.Format(PATH_NOT_FOUND_MESSAGE, startPoint, endPoint));
                }
                else
                {

                    Console.WriteLine(string.Format(SHORTEST_PATH_MESSAGE, startPoint, endPoint));
                    foreach (var point in shortestPath)
                    {
                        Console.WriteLine(point);
                    }
                }
                Console.WriteLine("");
            }
        }

        private Point GetPoint(string message)
        {
            int pointId = GetPointID(message);

            Point point;
            try
            {
                point = ModelDIContainer.Instance.Get<IStation>().Points.First(p => p.Id == pointId);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine(string.Format(INVALID_OPERATION_EXCEPTION_MESSAGE, pointId));
                point = GetPoint(message);
            }

            return point;
        }

        private int GetPointID(string message)
        {
            Console.Write(message);
            int pointId;
            try
            {
                pointId = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine(FORMAT_EXCEPTION_MESSAGE);
                pointId = GetPointID(message);
            }
            return pointId;
        }
    }
}

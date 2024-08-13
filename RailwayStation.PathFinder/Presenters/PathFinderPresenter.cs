using RailwayStation.Model;
using RailwayStation.PathFinder.Exceptions;
using System;

namespace RailwayStation.PathFinder
{
    public class PathFinderPresenter
    {
        private const string START_POINT_MESSAGE = "Введите ID начального участка пути :";
        private const string END_POINT_MESSAGE = "Введите ID конечного участка пути :";
        private const string SHORTEST_PATH_MESSAGE = "Кратчайший путь от {0} до {1}: ";
        private const string FORMAT_EXCEPTION_MESSAGE = "ID участка должен быть целым числом";
        private const string DIFFERENTIATE_MESSAGE = "Стартовый и финишный участки должны различаться";

        private readonly IPathFinder pathFinder;
        private readonly IStation station;

        public PathFinderPresenter() {
            pathFinder = PathFinderDIContainer.Instance.Get<IPathFinder>();
            station = PathFinderDIContainer.Instance.Get<IStation>();
        }

        public void OutputAllSections() {
            foreach (var section in station.Sections) {
                Console.WriteLine($"{section.Id}   {section.Description}");
            }
            Console.WriteLine("");
        }

        public void StartInput() {
            while (true) {
                try {
                    var startSection = GetSection(START_POINT_MESSAGE);
                    var endSection = GetSection(END_POINT_MESSAGE);

                    var path = pathFinder.GetShortestPath(startSection, endSection);

                    Console.WriteLine(string.Format(SHORTEST_PATH_MESSAGE, startSection, endSection));
                    Console.WriteLine(path);
                }
                catch (EqualSectionsException) {
                    Console.WriteLine(DIFFERENTIATE_MESSAGE);
                }
                catch (PathNotFoundException e) {
                    Console.WriteLine(e.Message);
                }
                catch (EntityNotFoundException e) {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException) {
                    Console.WriteLine(FORMAT_EXCEPTION_MESSAGE);
                }
                finally {
                    Console.WriteLine("");
                }
            }
        }

        private Section GetSection(string message) {
            var sectionId = GetSectionID(message);
            return station.GetSectionById(sectionId);
        }

        private int GetSectionID(string message) {
            Console.Write(message);

            var pointIdString = Console.ReadLine();
            var pointID = Convert.ToInt32(pointIdString);

            return pointID;
        }
    }
}

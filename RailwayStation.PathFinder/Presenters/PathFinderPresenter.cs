using RailwayStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RailwayStation.PathFinder
{
    public class PathFinderPresenter
    {
        private const string START_POINT_MESSAGE = "Введите ID начального участка пути :";
        private const string END_POINT_MESSAGE = "Введите ID конечного участка пути :";
        private const string PATH_NOT_FOUND_MESSAGE = "Пути от {0} до {1} не существует";
        private const string SHORTEST_PATH_MESSAGE = "Кратчайший путь от {0} до {1}: ";
        private const string FORMAT_EXCEPTION_MESSAGE = "ID участка должен быть целым числом";
        private const string INVALID_OPERATION_EXCEPTION_MESSAGE = "Участка с ID = {0} не существует";
        private const string DIFFERENTIATE_MESSAGE = "Стартовый и финишный участки должны различаться";

        private readonly IPathFinder pathFinder;
        private readonly IStation station;

        public PathFinderPresenter() 
        {
            pathFinder = PathFinderDIContainer.Instance.Get<IPathFinder>();
            station = PathFinderDIContainer.Instance.Get<IStation>();
        }

        public void OutputAllSections() 
        {
            station.Sections.ForEach(section => Console.WriteLine($"{section.Id}   {section.Description}"));
        }

        public void StartInput() 
        {
            while (true)
            {
                var startSection = GetSection(START_POINT_MESSAGE);
                var endSection = GetSection(END_POINT_MESSAGE, startSection);

                List<Section> shortestPath = pathFinder.GetFindShortestPath(startSection, endSection);

                if (shortestPath == null)
                {
                    Console.WriteLine(string.Format(PATH_NOT_FOUND_MESSAGE, startSection, endSection));
                }
                else
                {

                    Console.WriteLine(string.Format(SHORTEST_PATH_MESSAGE, startSection, endSection));
                    foreach (var point in shortestPath)
                    {
                        Console.WriteLine(point);
                    }
                }
                Console.WriteLine("");
            }
        }

        private Section GetSection(string message, Section startSection = null)
        {
            int sectionId = GetSectionID(message);

            Section section;
            try
            {
                section = station.Sections.First(s => s.Id == sectionId);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine(string.Format(INVALID_OPERATION_EXCEPTION_MESSAGE, sectionId));
                section = GetSection(message);
            }

            if (startSection != null && section.Equals(startSection)) 
            {
                Console.WriteLine(DIFFERENTIATE_MESSAGE);
                section = GetSection(message, startSection);
            }

            return section;
        }

        private int GetSectionID(string message)
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
                pointId = GetSectionID(message);
            }
            return pointId;
        }
    }
}

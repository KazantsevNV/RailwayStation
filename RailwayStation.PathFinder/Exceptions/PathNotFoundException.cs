using System;

namespace RailwayStation.PathFinder.Exceptions
{
    public class PathNotFoundException : Exception
    {
        public PathNotFoundException(string message)
            : base(message) { }
    }
}

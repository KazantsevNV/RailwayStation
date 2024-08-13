using System;

namespace RailwayStation.Model
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(string message)
            : base(message) { }
    }
}

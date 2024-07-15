using System.Collections.Generic;

namespace RailwayStation.Model
{
    public class Park : BaseEntityWithList<Way>
    {
        public Park(int id, string description, List<Way> entityes) : base(id, description, entityes) {
        }
    }
}

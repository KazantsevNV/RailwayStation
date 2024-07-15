using System.Collections.Generic;

namespace RailwayStation.Model
{
    public class Way : BaseEntityWithList<Section>
    {
        public Way(int id, string description, List<Section> entityes) : base(id, description, entityes) {
        }
    }
}

using System.Collections.Generic;

namespace RailwayStation.Model
{
    public class BaseEntityWithList<T> : BaseEntity where T : BaseEntity
    {
        private List<T> _entityes = new List<T>();

        public IReadOnlyList<T> Entityes => _entityes;

        public BaseEntityWithList(int id, string description, List<T> entityes) : base(id, description)
        {
            _entityes = entityes;
        }

        public void AddSection(T entity)
        {
            _entityes.Add(entity);
        }

        public void RemoveSection(T entity)
        {
            if (!_entityes.Contains(entity))
                return;

            _entityes.Remove(entity);
        }
    }
}

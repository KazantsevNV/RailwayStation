using System.Collections.Generic;

namespace RailwayStation.Model
{
    public class BaseEntityWithList<T> : BaseEntity where T : BaseEntity
    {
        private readonly List<T> entityes = new();

        public IReadOnlyList<T> Entityes => entityes;

        public BaseEntityWithList(int id, string description, List<T> entityes) : base(id, description) {
            this.entityes = entityes;
        }

        public void AddSection(T entity) {
            entityes.Add(entity);
        }

        public void RemoveSection(T entity) {
            if (!entityes.Contains(entity)) {
                return;
            }

            entityes.Remove(entity);
        }
    }
}

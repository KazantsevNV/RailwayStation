using System.Collections.Generic;

namespace RailwayStation.Model
{
    public class BaseEntityWithList<T> : BaseEntity where T : BaseEntity
    {
        private readonly List<T> entityes = new();

        protected IReadOnlyList<T> Entityes => entityes;

        public BaseEntityWithList(int id, string description, List<T> entityes) : base(id, description) {
            this.entityes = new List<T>(entityes);
        }

        protected void AddEntity(T entity) {
            entityes.Add(entity);
        }

        protected void RemoveEntity(T entity) {
            if (!entityes.Contains(entity)) {
                return;
            }

            entityes.Remove(entity);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Budget.Core;
using Budget.Core.Abstract.Repositories;
using Budget.Core.Entities;

namespace Budget.Storage.InMemory
{
    public class Repository<T> : IRepository<T> where T : IEntity
    {
        private int _next = 1;

        private IList<T> Entities { get; set; }

        public Repository() : this(new List<T>())
        {
        }

        private Repository(IList<T> entities)
        {
            Entities = entities;
        }

        public virtual void Add(T entity)
        {
            entity.Id = _next++;
            Entities.Add(entity);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Entities.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
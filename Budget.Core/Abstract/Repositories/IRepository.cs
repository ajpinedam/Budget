using System.Collections.Generic;

namespace Budget.Core.Abstract.Repositories
{
    public interface IRepository<T> : IEnumerable<T>
    {
        void Add(T entity);
    }
}
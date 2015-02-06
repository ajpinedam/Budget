using System.Linq;
using Budget.Core.Abstract.Repositories;
using Budget.Core.Entities;

namespace Budget.Core.Concrete.Queries
{
    public static class CategoriesQueries
    {
        public static Category ByName(this IRepository<Category> categories, string categoryName)
        {
            return categories.Single(c => c.Name == categoryName);
        }
    }
}
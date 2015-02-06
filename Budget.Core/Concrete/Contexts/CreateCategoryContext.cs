using Budget.Core.Abstract.Contexts;
using Budget.Core.Abstract.Repositories;
using Budget.Core.Entities;

namespace Budget.Core.Concrete.Contexts
{
    public class CreateCategoryContext : ICreateCategoryContext
    {
        private IRepository<Category> Categories { get; set; }

        public CreateCategoryContext(IRepository<Category> categories)
        {
            Categories = categories;
        }

        public void Exec(string categoryName)
        {
            Categories.Add(new Category(categoryName));
        }
    }
}
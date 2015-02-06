using System.Linq;
using Budget.Core;
using Budget.Core.Abstract.Repositories;
using Budget.Core.Entities;

namespace Budget.Storage.InMemory
{
    public class ExpensesRepository : Repository<Expense>
    {
        private IRepository<Category> Categories { get; set; }

        public ExpensesRepository(IRepository<Category> categories)
        {
            Categories = categories;
        }

        public override void Add(Expense expense)
        {
            base.Add(expense);

            Categories
                .Single(c => c.Id == expense.CategoryId)
                .Expenses.Add(expense);
        }
    }
}
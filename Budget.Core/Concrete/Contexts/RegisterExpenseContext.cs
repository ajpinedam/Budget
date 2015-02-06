using Budget.Core.Abstract.Contexts;
using Budget.Core.Abstract.Repositories;
using Budget.Core.Concrete.Queries;
using Budget.Core.Entities;

namespace Budget.Core.Concrete.Contexts
{
    public class RegisterExpenseContext : IRegisterExpenseContext
    {
        private IRepository<Expense> Expenses { get; set; }

        private IRepository<Category> Categories { get; set; }

        public RegisterExpenseContext(IRepository<Expense> expenses, IRepository<Category> categories)
        {
            Expenses = expenses;
            Categories = categories;
        }

        public void Exec(int amount, string categoryName)
        {
            Expenses.Add(new Expense
            {
                Amount = amount,
                CategoryId = Categories.ByName(categoryName).Id
            });
        }
    }
}
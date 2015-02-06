using Budget.Core;
using Budget.Core.Abstract.Contexts;
using Budget.Core.Abstract.Repositories;
using Budget.Core.Concrete.Contexts;
using Budget.Core.Entities;
using Budget.Storage.InMemory;
using Ninject.Modules;

namespace Budget.Specs.Steps
{
    public class Module : NinjectModule
    {
        public override void Load()
        {
            Bind<ICreateCategoryContext>().To<CreateCategoryContext>();
            Bind<IRegisterExpenseContext>().To<RegisterExpenseContext>();
            Bind<IViewSpentByCategoryContext>().To<ViewSpentByCategoryContext>();

            // Bind(typeof(IRepository<>)).To(typeof(Repository<>));
            Bind<IRepository<Category>>().To<Repository<Category>>().InSingletonScope();
            Bind<IRepository<Expense>>().To<ExpensesRepository>().InSingletonScope();
        }
    }
}
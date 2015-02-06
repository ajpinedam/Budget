using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Budget.Core.Abstract.Contexts;
using Budget.Core.Abstract.Repositories;
using Budget.Core.Entities;

namespace Budget.Core.Concrete.Contexts
{
    public class ViewSpentByCategoryContext : IViewSpentByCategoryContext
    {
        private IRepository<Category> Categories { get; set; }

        public ViewSpentByCategoryContext(IRepository<Category> categories)
        {
            Categories = categories;
        }

        public ISpentByCategoryPresenter Exec()
        {
            return new Presenter(Categories);
        }

        public class Presenter : ISpentByCategoryPresenter
        {
            public IRepository<Category> Categories { get; set; }

            public Presenter(IRepository<Category> categories)
            {
                Categories = categories;
            }

            public int Total
            {
                get { return this.Sum(r => r.SubTotal); }
            }

            public IEnumerator<ISpentByCategoryPresenterRow> GetEnumerator()
            {
                return Categories.Select(c => new Row(c)).GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public class Row : ISpentByCategoryPresenterRow
            {
                private Category Category { get; set; }

                public Row(Category category)
                {
                    Category = category;
                }

                public string CategoryName
                {
                    get { return Category.Name; }
                }

                public int SubTotal
                {
                    get { return Category.Expenses.Sum(e => e.Amount); }
                }
            }
        }
    }

}
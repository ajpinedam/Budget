using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Budget.Core.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public Category(string categoryName)
        {
            Name = categoryName;
            Expenses = new Collection<Expense>();
        }

        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
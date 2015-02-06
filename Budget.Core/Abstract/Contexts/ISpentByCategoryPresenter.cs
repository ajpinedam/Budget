using System.Collections.Generic;

namespace Budget.Core.Abstract.Contexts
{
    public interface ISpentByCategoryPresenter : IEnumerable<ISpentByCategoryPresenterRow>
    {
        int Total { get; }
    }

    public interface ISpentByCategoryPresenterRow
    {
        string CategoryName { get; }

        int SubTotal { get;  }
    }
}
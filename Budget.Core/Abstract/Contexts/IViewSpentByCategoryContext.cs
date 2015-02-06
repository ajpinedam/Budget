namespace Budget.Core.Abstract.Contexts
{
    public interface IViewSpentByCategoryContext
    {
        ISpentByCategoryPresenter Exec();
    }
}
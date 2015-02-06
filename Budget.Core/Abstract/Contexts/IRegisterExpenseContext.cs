namespace Budget.Core.Abstract.Contexts
{
    public interface IRegisterExpenseContext
    {
        void Exec(int amount, string categoryName);
    }
}
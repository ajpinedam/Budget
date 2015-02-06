namespace Budget.Core.Abstract.Contexts
{
    public interface ICreateCategoryContext
    {
        void Exec(string categoryName);
    }
}
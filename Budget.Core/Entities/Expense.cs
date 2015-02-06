namespace Budget.Core.Entities
{
    public class Expense : IEntity
    {
        public int Id { get; set; }
        
        public int Amount { get; set; }
        
        public int CategoryId { get; set; }
    }
}
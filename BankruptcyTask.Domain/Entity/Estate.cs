using BankruptcyTask.Domain.Entity;

namespace BankruptcyTask.Domain
{
    public class Estate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; }
        public Debtor Debtor { get; set; }
        public int DebtorId { get; set; }
        public bool IsRealize { get; set; }
        
    }
}
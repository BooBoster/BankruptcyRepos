using BankruptcyTask.Domain.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankruptcyTask.Domain
{
    public class Estate
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; }
        public Debtor Debtor { get; set; }
        [ForeignKey("Debtor")]
        public int DebtorId { get; set; }
        [Required]
        public bool IsRealize { get; set; }
        
    }
}
using BankruptcyTask.Domain.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankruptcyTask.Domain
{
    public class Estate
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Длина строки должна быть от 1 до 100 символов")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Обязательное поле")]
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; }
        public Debtor Debtor { get; set; }
        [ForeignKey("Debtor")]
        public int DebtorId { get; set; }
        [Required(ErrorMessage = "Обязательное поле")]
        public bool IsRealize { get; set; }
        
    }
}
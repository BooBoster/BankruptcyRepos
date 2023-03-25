using BankruptcyTask.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptcyTask.Domain.Entity
{
    public class Debtor
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Длина строки должна быть от 2 до 50 символов")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Длина строки должна быть от 2 до 50 символов")]
        public string SecondName { get; set; }
        [Required(ErrorMessage = "Не указана фамилия")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 2 до 50 символов")]
        public string SurName { get; set; }
        public ICollection<Estate>? EstateList { get; set; }
        [ForeignKey("Arbitrator")]
        public int? ArbitratorId { get; set; }
        public Arbitrator? Arbitrator { get; set; }
    }
}

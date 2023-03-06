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
        [Required]
        public string Name { get; set; }
        public string? SurName { get; set; }
        public ICollection<Estate>? EstateList { get; set; }
        [ForeignKey("Arbitrator")]
        public int? ArbitratorId { get; set; }
        public Arbitrator? Arbitrator { get; set; }
    }
}

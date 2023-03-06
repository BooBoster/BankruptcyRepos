using BankruptcyTask.Domain;
using BankruptcyTask.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptcyTask.Models.ViewModel
{
    public class DebtorViewModel
    {
        public string Name { get; set; }
        public string? SurName { get; set; }
        public ICollection<Estate> EstateList { get; set; }
    }
}

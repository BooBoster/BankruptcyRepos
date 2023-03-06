using BankruptcyTask.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptcyTask.Models.ViewModel
{
    public class EstateViewModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsRealize { get; set; }
    }
}

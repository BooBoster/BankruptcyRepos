using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptcyTask.Domain.Entity
{
    public class Debtor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public List<Estate> EstateList { get; set; }
    }
}

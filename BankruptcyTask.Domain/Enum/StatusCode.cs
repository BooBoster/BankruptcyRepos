using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptcyTask.Domain.Enum
{
    public enum StatusCode
    {
        Success = 100,
        EstateNotFound = 200,
        IternalServerEror = 500
    }
}

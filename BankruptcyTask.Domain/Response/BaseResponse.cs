﻿using BankruptcyTask.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptcyTask.Domain.Response
{
    public class BaseResponse<T>
    {
        public string? Description {get; set;}
        public StatusCode StatusCode { get; set;}
        public T Data { get; set;}
    }
}

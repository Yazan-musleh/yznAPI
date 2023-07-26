using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yzn_web.Domain.Model.Services.Communication
{
    public abstract class ResponseBase
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        protected ResponseBase(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}
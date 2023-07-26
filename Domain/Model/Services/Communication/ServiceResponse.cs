using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yzn_web.Domain.Model.Services.Communication
{
    public class ServiceResponse<T> : ResponseBase
    {

        public T Data { get; set; }
        protected ServiceResponse(bool Success, string Message, T Data) : base(Success, Message)
        {
            this.Data = Data;
        }

        /// <Summary>
        /// Creates a Success response
        /// </Summary>
        /// <Param name="T"> Item. </Param>
        /// <Returns> Response </Returns>

        public ServiceResponse(T Data, string Message) : this(true, Message, Data)
        {
        }

        /// <Summary>
        /// Creates an Error response
        /// </Summary>
        /// <Param name="Message"> Error Response. </Param>
        /// <Returns> Response </Returns>

        public ServiceResponse(string Message) : this(false, Message, default)
        {
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yzn_web.Domain.Model.Services.Communication
{
    public interface IUnitOfWork
    {
        Task SaveAsync();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yzn_web.Domain.Model.Services.Communication;
using yzn_web.Persistance.Context;
using yzn_web.Persistance.Repository;

namespace yzn_web.Services.Coummunication
{
    public class UnitOfWork : BaseRepository, IUnitOfWork
    {
        public UnitOfWork(DataContext context) : base(context)
        {
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
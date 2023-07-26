using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yzn_web.Persistance.Context;

namespace yzn_web.Persistance.Repository
{
    public class BaseRepository   
    {
        public readonly DataContext _context;

        public BaseRepository(DataContext context)
        {
            _context = context;
        }
    }
}
using Microsoft.EntityFrameworkCore;
using yzn_web.Domain.Model.Entities;

namespace yzn_web.Persistance.Context
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        public DbSet<Blog> Blogs => Set<Blog>();
    }

}
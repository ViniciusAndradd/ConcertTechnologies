using Microsoft.EntityFrameworkCore;
using CrudMaquinas.Entities;

namespace CrudMaquinas.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Machine> Machines { get; set; }
    }
}

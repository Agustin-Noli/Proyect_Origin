using ApiOrigin.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiOrigin.Contexts
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Home> Home { get; set; }

        public DbSet<Balance> Balance { get; set; }

        public DbSet<Reporte> Reporte { get; set; }
    }
}

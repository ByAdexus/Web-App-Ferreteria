using Ferreteria.Data.Modelo;
using Microsoft.EntityFrameworkCore;

namespace Ferreteria.Data
{
    public class AppDbContext:DbContext 

    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<producto> productos { get; set; }
    }
}

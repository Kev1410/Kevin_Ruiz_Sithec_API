using KevinRuizAPI.Entidades;
using Microsoft.EntityFrameworkCore;

namespace KevinRuizAPI.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
        {

        }

        public DbSet<Humano>Humanos { get; set; }
    }
}

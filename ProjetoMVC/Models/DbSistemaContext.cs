using Microsoft.EntityFrameworkCore;

namespace ProjetoMVC.Models
{
    public class DbSistemaContext : DbContext
    {
        public DbSistemaContext(DbContextOptions<DbSistemaContext> options)
            : base(options)
        {
        }

        public DbSet<Quarto> Quartos { get; set; }
    }
}
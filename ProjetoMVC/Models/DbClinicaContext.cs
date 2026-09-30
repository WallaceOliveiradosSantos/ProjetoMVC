using Microsoft.EntityFrameworkCore;

namespace ProjetoMVC.Models;

public partial class DbClinicaContext : DbContext
{
    public DbClinicaContext(DbContextOptions<DbClinicaContext> options)
        : base(options)
    {
    }

    public DbSet<Consulta> Consultas { get; set; }
}
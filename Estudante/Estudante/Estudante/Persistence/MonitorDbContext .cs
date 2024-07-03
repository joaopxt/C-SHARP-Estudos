using Estudante.Entities;
using Microsoft.EntityFrameworkCore;

namespace Estudante.Persistence;
public class MonitorDbContext : DbContext { //Configurando o context do Banco de Dados

    private readonly DbContext _contextMonitor;

    public DbSet<MonitorA> Monitores { get; set; }

    public MonitorDbContext(DbContextOptions<MonitorDbContext> options) : base(options) {

    }

    protected override void OnModelCreating(ModelBuilder builder) {
        builder.Entity<MonitorA>(a => {
            a.HasKey(x => x.Id);
            a.Property(x => x.Nome).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            a.Property(x => x.Curso).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            a.Property(x => x.Semestre).HasColumnType("int");
            a.Property(x => x.MateriaMonitorada).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            a.Property(x => x.Bolsa).HasColumnType("double");
            a.Property(x => x.Orientador).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
        });
    }

}

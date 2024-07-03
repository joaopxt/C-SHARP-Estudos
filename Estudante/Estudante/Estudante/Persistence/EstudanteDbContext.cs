using Estudante.Entities;
using Microsoft.EntityFrameworkCore;

namespace Estudante.Persistence;
public class EstudanteDbContext : DbContext { //Configurando o context do Banco de Dados

    private readonly DbContext _context;

    public DbSet<Aluno> Alunos { get; set; }

    public EstudanteDbContext(DbContextOptions<EstudanteDbContext> options) : base(options) {

    }

    protected override void OnModelCreating(ModelBuilder builder) {
        builder.Entity<Aluno>(a => {
            a.HasKey(x => x.Id);
            a.Property(x => x.Nome).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            a.Property(x => x.Curso).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            a.Property(x => x.Semestre).HasColumnType("int");
        });
    }

}

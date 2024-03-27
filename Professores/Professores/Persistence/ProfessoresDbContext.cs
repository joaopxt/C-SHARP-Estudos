using Microsoft.EntityFrameworkCore;
using Professores.Entities;

namespace Professores.Persistence;

public class ProfessoresDbContext: DbContext {
    public DbSet<Professor> Professores { get; set; }

    public ProfessoresDbContext(DbContextOptions<ProfessoresDbContext> options) : base(options) {
    }

    protected override void OnModelCreating(ModelBuilder builder) {
        builder.Entity<Professor>(x => {
            x.HasKey(x => x.Id);
            x.Property(x => x.Nome).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            x.Property(x => x.Curso).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
        });
    }
}

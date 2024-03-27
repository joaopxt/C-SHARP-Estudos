using Library.Entities;
using Microsoft.EntityFrameworkCore;


namespace Library.Entities.Persistence;

public class LivrosDbContext: DbContext
{
    public DbSet<Livro> Livros { get; set; }

    public LivrosDbContext(DbContextOptions<LivrosDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder) {
        builder.Entity<Livro>(l => {
            l.HasKey(x => x.Id);
            l.Property(x => x.Nome).IsRequired();
            l.Property(x => x.Autor).IsRequired(false);
            l.Property(x => x.Ano).HasMaxLength(4);
        });
    }
}

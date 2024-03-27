using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace Album.Entities.Persistence;

public class MusicasDbContext: DbContext {

    public DbSet<Musica> Musicas { get; set; }
    public DbSet<Artista> Artistas { get; set; }

    public MusicasDbContext(DbContextOptions<MusicasDbContext> options): base(options) {
        
    }

    protected override void OnModelCreating(ModelBuilder builder) {
        builder.Entity<Musica>(m => {
            m.HasKey(m => m.Id);

            m.Property(m => m.Nome).
            IsRequired().
            HasMaxLength(100).
            HasColumnType("varchar(100)");

            m.Property(m => m.Genero).IsRequired(false);

            m.HasMany(a => a.Artistas).
            WithOne().
            HasForeignKey(x => x.ArtistaId);
        });

        builder.Entity<Artista>(a => {
            a.HasKey(a => a.ArtistaId);
        });
    }
    
}

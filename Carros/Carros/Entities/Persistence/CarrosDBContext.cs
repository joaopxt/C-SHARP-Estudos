using Microsoft.EntityFrameworkCore;

namespace Carros.Entities.Persistence;

public class CarrosDbContext : DbContext
{
    public DbSet<Carro> Carros { get; set; }
    public CarrosDbContext(DbContextOptions<CarrosDbContext> options) : base(options){
        
    }

    protected override void OnModelCreating(ModelBuilder builder) {

        builder.Entity<Carro>(c => {
            c.HasKey(x => x.Id);
            c.Property(x => x.Modelo).IsRequired(true);
            c.Property(x => x.Ano).IsRequired()
            .HasColumnType("int");
            c.Property(x => x.Marca).IsRequired(false);
            c.Property(x => x.Preco).IsRequired()
            .HasColumnType("decimal(12,2)");
        }
            
            );
    }
}

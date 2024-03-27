using Microsoft.EntityFrameworkCore;
using Nba.Entities;

namespace Nba.Entities.Persistence;

public class TimeDbContext : DbContext{
    public DbSet<Time> Times { get; set; }


    public TimeDbContext(DbContextOptions<TimeDbContext> options): base(options) {

    }

    protected override void OnModelCreating(ModelBuilder builder) {

        builder.Entity<Time>(e => {
            e.HasKey(x => x.Id);
            e.Property(x => x.Nome).IsRequired();
            e.Property(x => x.Trofeus).HasColumnType("int");
            e.Property(x => x.Conferencia).IsRequired(false).HasMaxLength(5).HasColumnType("varchar(5)");
            e.Property(x => x.Star).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
        });

    }
}

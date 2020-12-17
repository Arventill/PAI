using Microsoft.EntityFrameworkCore;
using ProgramowanieAplikacjiInternetowych.Repository.Models;

namespace ProgramowanieAplikacjiInternetowych.Repository
{
    public class PaiDbContext : DbContext
    {
        public PaiDbContext(DbContextOptions<PaiDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(entity => entity.Hash)
                .HasDefaultValue(string.Empty);

            modelBuilder.Entity<User>()
                .HasIndex(entity => entity.Hash)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasMany(u => u.Tasks)
                .WithOne(t => t.User)
                .IsRequired();
        }

        #region DbSets

        public DbSet<User> Users { get; set; }

        public DbSet<Task> Tasks { get; set; }

        #endregion
    }
}

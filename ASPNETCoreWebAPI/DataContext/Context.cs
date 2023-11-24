using ASPNETCoreWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreWebAPI.DataContext
{
    public class Context:DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Addresses> Addresses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the one-to-many relationship
            modelBuilder.Entity<Users>()
                .HasMany(p => p.Address)
                .WithOne(a => a.Users)
                .HasForeignKey(a => a.UserId);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("apiDatabase");
        }
    }
}

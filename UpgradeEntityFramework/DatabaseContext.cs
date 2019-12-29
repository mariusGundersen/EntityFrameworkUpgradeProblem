using Microsoft.EntityFrameworkCore;

namespace UpgradeEntityFramework
{
    public class DatabaseContext : DbContext
    {
        public DbSet<MemberUser> MemberUsers { get; set; }

        public DbSet<EventSignup> EventSignups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=UpgradeEntityFramework");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<EventSignup>(signup =>
            {
                signup
                    .HasOne(s => s.Partner)
                    .WithMany()
                    .HasForeignKey(s => s.PartnerEmail)
                    .HasPrincipalKey(s => s.NormalizedEmail)
                    .IsRequired(false);
            });
        }
    }
}

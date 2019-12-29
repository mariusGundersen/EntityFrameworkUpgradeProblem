using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

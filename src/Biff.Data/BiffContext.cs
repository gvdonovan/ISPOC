using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Biff.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Biff.Data
{
    public class BiffContext : IdentityDbContext<BiffUser> // DbContext
    {
        public BiffContext(DbContextOptions<BiffContext> options) : base(options)
        {
        }

        public DbSet<CommandDefinition> CommandDefinitions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.AddConfiguration(new CommandDefinitionConfiguration());
            modelBuilder.Entity<IdentityRole>().ForSqlServerToTable("Roles", "security");
            modelBuilder.Entity<IdentityRoleClaim<string>>().ForSqlServerToTable("RoleClaims", "security");
            modelBuilder.Entity<BiffUser>().ForSqlServerToTable("Users", "security");
            modelBuilder.Entity<IdentityUserClaim<string>>().ForSqlServerToTable("UserClaims", "security");
            modelBuilder.Entity<IdentityUserLogin<string>>().ForSqlServerToTable("UserLogins", "security");
            modelBuilder.Entity<IdentityUserRole<string>>().ForSqlServerToTable("UserRoles", "security");
            modelBuilder.Entity<IdentityUserToken<string>>().ForSqlServerToTable("UserTokens", "security");
        }
        
    }

    public class BiffUser : IdentityUser
    {
        public int OfficeNumber { get; set; }
    }
}

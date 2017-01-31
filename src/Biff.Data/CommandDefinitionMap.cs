using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biff.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biff.Data
{
    internal static class ModelBuilderExtensions
    {
        public static void AddConfiguration<TEntity>(this ModelBuilder modelBuilder, DbEntityConfiguration<TEntity> entityConfiguration) where TEntity : class
        {
            modelBuilder.Entity<TEntity>(entityConfiguration.Configure);
        }
    }

    internal abstract class DbEntityConfiguration<TEntity> where TEntity : class
    {
        public abstract void Configure(EntityTypeBuilder<TEntity> entity);
    }

    internal class CommandDefinitionConfiguration : DbEntityConfiguration<CommandDefinition>
    {
        public override void Configure(EntityTypeBuilder<CommandDefinition> entity)
        {
            entity.ForSqlServerToTable("CommandDefinition");
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Name).HasMaxLength(255).IsRequired();            
        }
    }    
}

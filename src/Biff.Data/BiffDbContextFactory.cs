using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Biff.Data
{
    public class SchoolDbContextFactory : IDbContextFactory<BiffContext>
    {
        public BiffContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<BiffContext>();
            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BiffCoreDb2;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new BiffContext(builder.Options);
        }
    }
}

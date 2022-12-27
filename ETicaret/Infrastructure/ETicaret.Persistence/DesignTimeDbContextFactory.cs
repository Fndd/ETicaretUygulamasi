using ETicaret.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<dbContext>
    {
        public dbContext CreateDbContext(string[] args)
        { 
            DbContextOptionsBuilder<dbContext> optionsBuilder = new(); 
            optionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new dbContext(optionsBuilder.Options);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QLTT.Data.EF
{
    public class QLTTDbContextFactory : IDesignTimeDbContextFactory<QLTTDBContext>
    {
        public QLTTDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();

            var connectionString = configuration.GetConnectionString("QLTTSolutionDB");
            var optionsBuilder = new DbContextOptionsBuilder<QLTTDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new QLTTDBContext(optionsBuilder.Options);
        }
    }
}

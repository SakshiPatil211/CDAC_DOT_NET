using EntityFramework.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.DAL
{
    internal class DBContext: DbContext
    {
        public DbSet<Employee3> emp { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            
            builder.SetBasePath(Directory.GetCurrentDirectory());

            builder.AddJsonFile("appsettings.json");

            IConfiguration configuration = builder.Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("IETDb"));
        }
    }
}

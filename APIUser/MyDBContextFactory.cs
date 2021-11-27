using DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace APIUser
{
    public class MyDBContextFactory : IDesignTimeDbContextFactory<myDbContext>
    {
        public myDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot SettingsObj
                = new ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            DbContextOptionsBuilder<myDbContext>Builder
                 = new DbContextOptionsBuilder<myDbContext>();
            Builder.UseSqlServer(SettingsObj.GetConnectionString("ebaydatabase"));

            myDbContext Context = new myDbContext(Builder.Options);
            return Context;
        }
    }
}

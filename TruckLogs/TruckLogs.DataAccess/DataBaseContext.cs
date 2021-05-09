using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace DataAccess
{
    public class DataBaseContext:DbContext
    {
        private readonly IConfiguration Configuration;
        public DataBaseContext(IConfiguration configuration)
        {
            Configuration = configuration;

        }
        public DbSet<DriverEntity> Driver { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(Configuration.GetSection("DBSetting:ConnectionString").Value);
            }
        }
    }
}

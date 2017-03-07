using BandD.Logger.Domain;
using BandD.Logger.EntityClassConfiguration;
using System.Data.Entity;

namespace BandD.Logger
{
    public class LoggerContext : DbContext
    {
        public DbSet<BandDServisLogger> BandDServisLogger { get; set; }

        public LoggerContext() : base("BanddLogger")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BandDServisLoggerEntityConfiguration());
        }
    }
}
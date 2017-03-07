using BandD.Logger.Domain;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BandD.Logger.EntityClassConfiguration
{
    public class BandDServisLoggerEntityConfiguration : EntityTypeConfiguration<BandDServisLogger>
    {
        public BandDServisLoggerEntityConfiguration()
        {
            this.HasKey<Guid>(k => k.ServisLoggerId);
            this.Property(p => p.Number).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace Tourism_App
{
    class PassengerConfigrations : EntityTypeConfiguration<Passenger>
    {

        public PassengerConfigrations()
        {
            this.ToTable("Passenger");
            this.Property(p => p.ID).IsRequired()
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(p => p.NationalID).IsRequired().HasMaxLength(14).IsFixedLength();
            this.Property(p => p.Phone).HasMaxLength(11).IsFixedLength();
        }

    }
}

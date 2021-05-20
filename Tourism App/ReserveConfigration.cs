using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace Tourism_App
{
    class ReserveConfigration : EntityTypeConfiguration<Reserve>
    {

        public ReserveConfigration()
        {
            this.ToTable("Reservations");
            this.Property(r => r.ID).IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(r => r.JourneyID).HasColumnAnnotation("ForeignKey", "Journey");
            this.Property(r => r.PassengerID).HasColumnAnnotation("ForeignKey", "Passenger");
            this.Property(r => r.EmployeeID).HasColumnAnnotation("ForeignKey", "Employee");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace Tourism_App
{
    class JourneyConfigrations : EntityTypeConfiguration<Journey>
    {

        public JourneyConfigrations()
        {
            this.ToTable("Journey");
            this.Property(j => j.ID).IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }

    }
}

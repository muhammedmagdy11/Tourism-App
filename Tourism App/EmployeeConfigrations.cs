using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace Tourism_App
{
    class EmployeeConfigrations : EntityTypeConfiguration<Employee>
    {

        public EmployeeConfigrations()
        {
            this.ToTable("Employee");
            this.Property(e => e.ID).IsRequired()
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(e => e.NationalID).IsRequired().HasMaxLength(14).IsFixedLength();
            this.Property(e => e.Phone).HasMaxLength(11).IsFixedLength();
        }

    }
}

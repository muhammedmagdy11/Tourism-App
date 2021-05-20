using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourism_App
{
    class Data_Context : DbContext
    {

        public Data_Context():base("DefaultConnection")
        { }



        public DbSet<Employee> Employees { get; set; }
        public DbSet<Journey> Journeys { get; set; }
        public DbSet<Reserve> Reserves { get; set; }
        public DbSet<Passenger> Passengers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new EmployeeConfigrations());
            modelBuilder.Configurations.Add(new JourneyConfigrations());
            modelBuilder.Configurations.Add(new PassengerConfigrations());
            modelBuilder.Configurations.Add(new ReserveConfigration());
        }

    }
}

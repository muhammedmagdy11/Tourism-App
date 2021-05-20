using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourism_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static Data_Context _dbContext;
        [STAThread]
        static void Main()
        {
            _dbContext = new Data_Context();
            Database.SetInitializer<Data_Context>(new MigrateDatabaseToLatestVersion<Data_Context, Migrations.Configuration>() );


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region Dummy Data


            ////Dummy Data that should be in the Database to access functionalities

            //_dbContext.Employees.Add(new Employee()
            //{
            //    Name = "Mahmoud",
            //    Gender = Gender.male,
            //    Age = 24,
            //    Email = "mahmoud@gmail.com",
            //    Password = "123456",
            //    Phone = "01550414857",
            //    IsAdmin = true,
            //    NationalID = "1234567891234"
            //});
            //_dbContext.Employees.Add(new Employee()
            //{
            //    Name = "Ahmed",
            //    Gender = Gender.male,
            //    Age = 23,
            //    Email = "ahmed@gmail.com",
            //    Password = "123456",
            //    Phone = "01111111111",
            //    IsAdmin = false,
            //    NationalID = "1234567891234"
            //});
            //_dbContext.Employees.Add(new Employee()
            //{
            //    Name = "Salma",
            //    Gender = Gender.female,
            //    Age = 22,
            //    Email = "salma@gmail.com",
            //    Password = "123456",
            //    Phone = "01222222222",
            //    IsAdmin = false,
            //    NationalID = "1234567891234"
            //});

            //_dbContext.Journeys.Add(new Journey()
            //{
            //    Title = "Gero-Land",
            //    Description = "Gaming area in Cairo",
            //    MaxNumber = 5,
            //    TravelWay = Type.Bus,
            //    TicketCost = 100,
            //    NumOfDays = 1,
            //    Location = "Cairo",
            //    Date = new DateTime(2021, 4, 7),
            //    NumOfReservedChairs = 0
            //});
            //_dbContext.Journeys.Add(new Journey()
            //{
            //    Title = "Wady El Ryan",
            //    Description = "Skitting area and waterfalls with breakfast",
            //    MaxNumber = 20,
            //    TravelWay = Type.Bus,
            //    TicketCost = 180,
            //    NumOfDays = 1,
            //    Location = "Fayuem",
            //    Date = new DateTime(2021, 4, 7),
            //    NumOfReservedChairs = 0
            //});
            //_dbContext.Journeys.Add(new Journey()
            //{
            //    Title = "Sharm-El-Sheikh",
            //    Description = "Hotel 5 stars with breakfast and dinner",
            //    MaxNumber = 5,
            //    TravelWay = Type.Plane,
            //    TicketCost = 4500,
            //    NumOfDays = 5,
            //    Location = "Sharm-El-Sheikh",
            //    Date = new DateTime(2021, 4, 7),
            //    NumOfReservedChairs = 0
            //});
            //_dbContext.Reserves.Add(new Reserve()
            //{

            //    Employee = new Employee()
            //    {
            //        Name = "ahmed",
            //        Gender = Gender.female,
            //        Age = 22,
            //        Email = "ahmed@gmail.com",
            //        Password = "123456",
            //        Phone = "01222222222",
            //        IsAdmin = false,
            //        NationalID = "1234567891234"
            //    },
            //    Journey = new Journey()
            //    {
            //        Title = "Siwa",
            //        Description = "Hotel 5 stars with breakfast and dinner",
            //        MaxNumber = 5,
            //        TravelWay = Type.Plane,
            //        TicketCost = 4500,
            //        NumOfDays = 5,
            //        Location = "Sharm-El-Sheikh",
            //        Date = new DateTime(2021, 4, 7),
            //        NumOfReservedChairs = 0
            //    },
            //    Passenger = new Passenger { Name = "ali", Age = 19, NationalID = "90978787998", Phone = "9878789" }

            //});

            //_dbContext.Reserves.Add(new Reserve()
            //{

            //    EmployeeID = 3,
            //    JourneyID = 81,
            //    PassengerID = 3

            //});
            //_dbContext.SaveChanges();


            #endregion

            Application.Run(new Form1());

        }
    }
}

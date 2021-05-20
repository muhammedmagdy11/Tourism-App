using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourism_App
{
    class Reserve
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public int JourneyID { get; set; }
        public int PassengerID { get; set; }
        public int NumOfTickets { get; set; }


        public virtual Journey Journey { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Passenger Passenger { get; set; }


    }
}

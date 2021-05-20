using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourism_App
{
    class Passenger
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string NationalID { get; set; }


        public virtual List<Reserve> Reserves { get; set; }

    }
}

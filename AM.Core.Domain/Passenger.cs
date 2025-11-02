using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Passenger
    {
        public string EmailAddress { get; set; }
        public string PassportNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }

        // Navigation property
        public virtual IList<Flight> Flights { get; set; }

        // ToString override
        public override string ToString()
        {
            return "EmailAddress:" + EmailAddress +
                   "PassportNumber:" + PassportNumber +
                   "BirthDate:" + BirthDate +
                   "FirstName:" + FirstName +
                   "LastName:" + LastName +
                   "TelNumber:" + TelNumber;
        }

    }
}

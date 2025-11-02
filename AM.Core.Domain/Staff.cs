using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Staff:Passenger
    {
        public int Salary { get; set; }
        public string Function { get; set; }
        public DateTime EmploymentDate { get; set; }

    }
}

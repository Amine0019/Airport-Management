using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Plane
    {
        public int Capacity { get; set; }
        public int PlaneId { get; set; }
        public DateTime ManufactureDate { get; set; }
        public PlaneType PlaneType { get; set; }

        //Navigation property
        public IList<Flight> Flights { get; set; }

        //ToString override
        public override string ToString()
        {
            return "Capacity" + Capacity +
                   "PlaneId:" + PlaneId +
                   "ManufactureDate:" + ManufactureDate +
                   "PlaneType:" + PlaneType;
        }
    }
}

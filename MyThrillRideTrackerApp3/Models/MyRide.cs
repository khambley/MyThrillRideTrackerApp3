using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyThrillRideTrackerApp3.Models
{
    public class MyRide : BaseModel
    {
        public int MyRideId { get; set; }

        public int RideId { get; set; }
        public Ride Ride { get; set; }

        public int VisitId { get; set; }
        public Visit Visit { get; set; }

        public int MyRideRating { get; set; }
        public string MyRideComments { get; set; }

    }
}

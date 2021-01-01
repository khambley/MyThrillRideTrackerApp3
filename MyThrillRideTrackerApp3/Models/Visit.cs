using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyThrillRideTrackerApp3.Models
{
    public class Visit : BaseModel
    {
        public int VisitId { get; set; }
        public DateTime VisitDate { get; set; }

        public int ParkId { get; set; }
        public Park Park { get; set; }

        public List<MyRide> MyRides { get; set; }

        public int VisitRating { get; set; }
        public string VisitComments { get; set; }
    }
}

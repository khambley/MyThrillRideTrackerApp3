using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MyThrillRideTrackerApp3.Models
{
    public class ImageFileName
    {
        public int ImageFileNameId { get; set; }
        public string FileName { get; set; }

        public int? ParkId { get; set; }
        public Park Park { get; set; }

        public int? RideId { get; set; }
        public Ride Ride { get; set; }

        public int? VisitId { get; set; }
        public Visit Visit { get; set; }
        
        public int? MyRideId { get; set; }
        public MyRide MyRide { get; set; }
    }
}

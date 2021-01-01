using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MyThrillRideTrackerApp3.Models
{
    public class BaseModel
    {
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public List<ImageFileName> ImageFiles { get; set; }
    }
}

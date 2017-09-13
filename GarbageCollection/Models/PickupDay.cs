using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GarbageCollection.Models
{
    public class PickupDay
    {
        public int Id { get; set; }

        [Display(Name = "Pickup Day")]
        public string Day { get; set; }

        public string CustomerId { get; set; }
    }
}
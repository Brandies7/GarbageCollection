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

        [Required]
        [Display(Name = "Pickup Day")]
        public string Day { get; set; }
    }
}
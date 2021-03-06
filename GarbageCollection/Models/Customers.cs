﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GarbageCollection.Models
{
    public class Customers
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }

        [Display(Name = "Payment Option")]
        public string PaymentOption { get; set; }

        [Display(Name = "Desired Pick Up Day")]
        
        public string PickupDay { get; set; }
        

        [Display(Name = "Cancel Service")]
        public bool CancelService { get; set; }

        [Display(Name = "Extra PickUp")]
        public string ExtraPickup { get; set; }

        [Display(Name = "No Pickup")]
        public string NoPickup { get; set; }

        [Display(Name = "Change Pickup Day")]
        public string ChangePickup { get; set; }

        
      
        

        
    }


}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6_Music.Models
{
    public class Purchase
    {
        [HiddenInput ( DisplayValue = false )]
        public int Id { get; set; }

        [Required ( ErrorMessage = "It is required" )]
        [UIHint ( "MultilineText" )]
        public string ShippingData { get; set; }

        [Required ( ErrorMessage = "It is required" )]
        [DataType ( DataType.Date )]
        public DateTime Date { get; set; }

        public int? DiskId { get; set; }
        public Disk Disk { get; set; }
    }
}
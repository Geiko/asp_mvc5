using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6_Music.Models
{
    public class Genre
    {
        [HiddenInput ( DisplayValue = false )]
        public int Id { get; set; }

        [Required ( ErrorMessage = "It is required" )]
        [StringLength ( 50, MinimumLength = 2, ErrorMessage = "The Genre shold be in range 2-50 symbols" )]
        [DisplayName ( "Genre" )]
        public string Name { get; set; }

        public ICollection<Disk> Disks { get; set; }
        public Genre ( )
        {
            Disks = new List<Disk> ( );
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6_Music.Models
{
    public class Artist
    {
        [HiddenInput ( DisplayValue = false )]
        public int Id { get; set; }

        [Required ( ErrorMessage = "It is required" )]
        [StringLength ( 50, MinimumLength = 2, ErrorMessage = "Artist's name shold be in range 2-50 symbols" )]
        [DisplayName ( "Artist" )]
        public string Name { get; set; }
    }
}
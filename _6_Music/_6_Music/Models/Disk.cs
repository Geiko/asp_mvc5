using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6_Music.Models
{
    public class Disk
    {
        [HiddenInput ( DisplayValue = false )]
        public int Id { get; set; }
        
        public int? ArtistId { get; set; }
        public Artist Artist { get; set; }
        
        public int? GenreId { get; set; }
        public Genre Genre { get; set; }

        [Required ( ErrorMessage = "It is required" )]
        [StringLength ( 50, MinimumLength = 2, ErrorMessage = "The Title should be in range 2-50 symbols" )]
        [DisplayName ( "ALbum" )]
        public string Title { get; set; }

        [Required ( ErrorMessage = "It is required" )]
        [Range ( 0.00, 100.00, ErrorMessage = "The Prise shold be in range 0 - 100 US$" )]
        public decimal Price { get; set; }
        
        [DisplayName ( "Disk URL" )]
        [StringLength ( 1024 )]
        public string DiskUrl { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5_Team.Models
{
    public class Team
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name="Team Name")]
        [UIHint("String")]
        [Required]
        public string Name { get; set; }

        [Display(Name="City")]
        [UIHint ( "String" )]
        [Required]
        public string City { get; set; }

        [Display(Name="Coach")]
        [UIHint ( "String" )]
        [Required]
        public string Coach { get; set; }

        public ICollection<Player> Players { get; set; }
        public Team ( )
        {
            Players = new List<Player> ( );
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5_Team.Models
{
    public class Player
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required]
        [UIHint("String")]
        [StringLength ( 10, ErrorMessage = "First Name must be less than 10 symbols" )]
        public string FirstName { get; set; }

        [Required]
        [UIHint("String")]
        [StringLength ( 10, ErrorMessage = "Last Name must be less than 10 symbols" )]
        public string LastName { get; set; }

        [Required]
        public Position Position { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        public int? TeamId { get; set; }
        public Team Team { get; set; }
    }

    public enum Position
    {
        All, Forward, Midfielder, Halfback, Defeander, Goalkeeper
    }
}
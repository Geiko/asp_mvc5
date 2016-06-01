using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _4_LeatherCraft.Models
{
    public class Visitor
    {
        public int Id { get; set; }

        [Required ( ErrorMessage = "The FirstName field is required" )]
        [StringLength ( 21, MinimumLength = 2, ErrorMessage = "The String must be equal 2 - 21 symbols" )]
        [RegularExpression( @"^[A-Z][a-z]+$", ErrorMessage = "The First Name is not correct" ) ]
        public string FirstName { get; set; }

        [Required ( ErrorMessage = "The LastName field is required" )]
        [StringLength ( 21, MinimumLength = 2, ErrorMessage = "The String must be equal 2 - 21 symbols" )]
        [RegularExpression ( @"^[A-Z][a-z]+$", ErrorMessage = "The Last Name is not correct" )]
        public string LastName { get; set; }

        [Required ( ErrorMessage = "The Age field is required" )]
        [Range ( 16, 100, ErrorMessage = "Your Age is not appropriate" )]
        public int Age { get; set; }

        [Required ( ErrorMessage = "The Phone field is required" )]
        [StringLength ( 50, MinimumLength = 5, ErrorMessage = "The String must be equal 5 - 50 symbols" )]
        //[RegularExpression ( @"^[+0-9\(\)][0-9\-\(\)]{3,20}[0-9]$", ErrorMessage = "The Phone is not correct" )]
        [Phone]
        public string Phone { get; set; }

        [Required ( ErrorMessage = "The Email field is required" )]
        [StringLength ( 100, MinimumLength = 6, ErrorMessage = "The String must be equal 6 - 100 symbols" )]
        //[RegularExpression ( @"^\w\w*@\w+\.[a-z]{2,4}$", ErrorMessage = "The Phone is not correct" )]
        [EmailAddress]
        public string Email { get; set; }
    }
}
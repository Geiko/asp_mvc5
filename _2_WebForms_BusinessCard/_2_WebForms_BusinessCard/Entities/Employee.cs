using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2_WebForms_BusinessCard.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        public string GenerateHtml ( )
        {
            return string.Format ( $"<tr><td>{Id}</td><td>{Name}</td><td>{Department}</td><td>{Position}</td><td>{Salary}</td></tr>" );
        }
    }
}
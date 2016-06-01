using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _2_WebForms_BusinessCard.Entities
{
    public class CompanyContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
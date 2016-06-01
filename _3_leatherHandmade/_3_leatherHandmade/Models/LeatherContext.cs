using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _3_leatherHandmade.Models
{
    public class LeatherContext: DbContext
    {
        public DbSet<LeatherItem> LeatherItems { get; set; }
    }
}
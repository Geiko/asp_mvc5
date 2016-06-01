using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _4_LeatherCraft.Models
{
    public class LeatherContext: DbContext
    {
        public DbSet<LeatherItem> LeatherItems { get; set; }
    }
}
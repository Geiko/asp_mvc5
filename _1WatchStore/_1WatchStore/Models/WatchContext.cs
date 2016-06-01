using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _1WatchStore.Models
{
    public class WatchContext: DbContext
    {
        public DbSet<Watch> Watches { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}
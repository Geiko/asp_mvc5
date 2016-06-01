using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _6_Music.Models
{
    public class MusicContext: DbContext
    {
        public DbSet<Disk> Disks { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
    }
}
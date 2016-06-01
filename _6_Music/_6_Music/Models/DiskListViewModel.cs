using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6_Music.Models
{
    public class DiskListViewModel
    {
        public IEnumerable<Disk> Disks { get; set; }
        public SelectList Genres { get; set; }
        public SelectList Artists { get; set; }
    }
}
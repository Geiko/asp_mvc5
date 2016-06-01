using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1WatchStore.Models
{
    public class Watch
    {
        public int WatchId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
    }
}
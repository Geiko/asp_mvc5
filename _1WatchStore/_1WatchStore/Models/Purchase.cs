using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1WatchStore.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public int WatchId { get; set; }
        public string Client{ get; set; }
        public DateTime Date { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace _4_LeatherCraft.Models
{
    public class LeatherDbInitializer: DropCreateDatabaseAlways<LeatherContext>
    {
        protected override void Seed( LeatherContext db )
        {
            db.LeatherItems.Add ( new LeatherItem { Article = "b5", Nomination = "Bag", Price = 300 } );
            db.LeatherItems.Add ( new LeatherItem { Article = "f5", Nomination = "Furniture", Price = 100000 } );
            db.LeatherItems.Add ( new LeatherItem { Article = "bo5", Nomination = "Book", Price = 3300 } );
            db.LeatherItems.Add ( new LeatherItem { Article = "c5", Nomination = "PhoneCover", Price = 100 } );
            db.LeatherItems.Add ( new LeatherItem { Article = "g5", Nomination = "Gloves", Price = 800 } );

            base.Seed ( db );
        }
    }
}
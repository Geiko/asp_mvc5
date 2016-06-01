using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace _3_leatherHandmade.Models
{
    public class LeatherDbInitializer: DropCreateDatabaseAlways<LeatherContext>
    {
        protected override void Seed ( LeatherContext db )
        {
            db.LeatherItems.Add ( new LeatherItem { Nomination = "Bags", Article = "B2", Price = 800 } );
            db.LeatherItems.Add ( new LeatherItem { Nomination = "Furniture", Article = "F4", Price = 12300 } );
            db.LeatherItems.Add ( new LeatherItem { Nomination = "PhoneCover", Article = "P2", Price = 200 } );
            db.LeatherItems.Add ( new LeatherItem { Nomination = "BookCover", Article = "B2", Price = 8200 } );
            db.LeatherItems.Add ( new LeatherItem { Nomination = "Gloves", Article = "G2", Price = 700 } );

            base.Seed ( db );
        }
    }
}
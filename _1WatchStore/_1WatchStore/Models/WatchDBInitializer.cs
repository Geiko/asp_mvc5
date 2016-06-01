using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace _1WatchStore.Models
{
    public class WatchDbInitializer: DropCreateDatabaseAlways<WatchContext>
    {
        protected override void Seed ( WatchContext db )
        {
            db.Watches.Add ( new Watch { Brand = "Apple", Model = "Watch", Price = 299 } );
            db.Watches.Add ( new Watch { Brand = "Pebble ", Model = "Steel", Price = 179.99 } );
            db.Watches.Add ( new Watch { Brand = "Sony", Model = "SmartWatch 3", Price = 189 } );
            db.Watches.Add ( new Watch { Brand = "Samsung", Model = "Gear S2", Price = 249.99 } );
            db.Watches.Add ( new Watch { Brand = "Asus", Model = "ZenWatch 2", Price = 149 } );
            db.Watches.Add ( new Watch { Brand = "Tag", Model = "Heuer Connected", Price = 1100 } );
            db.Watches.Add ( new Watch { Brand = "Moto", Model = "360 2", Price = 229.99 } );

            base.Seed ( db );
        }
    }
}
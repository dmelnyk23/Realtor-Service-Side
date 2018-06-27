using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomInitializer<T> : DropCreateDatabaseAlways<DatabaseModel>
    {
        protected override void Seed(DatabaseModel context)
        {

            var lot = new Lot()
            {
                Price = 100000,
                Description = "Perfect for single man",
                Flat = true,
                SingleFamilyHouse = true
            };
            List<Lot> lots = new List<Lot> { lot };
            var user = new User()
            {
                Name = "Dima",
                Login = "admin",
                Password = "admin",
                IsAdmin = true,
                Lots = lots
            };
        }

    }
}

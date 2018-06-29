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
            Address address = new Address()
            {
                City = "Rivne",
                Country = "Ukraine",
                Street = "Soborna"
            };

            var lot = new Lot()
            {
                Price = 100000,
                Description = "Perfect for single man",
                House = true,
                IsSold = false,
                IsReserved = false,
                Apartment = false,
                Address = address,
                Flour = 1,
                RoomsCount = 3,
                Square = 100
            };
            List<Lot> lots = new List<Lot> { lot };
            var user = new User()
            {
                Name = "Dima",
                Login = "admin",
                Password = "admin",
                PhoneNumber = "11111111111",
                IsAdmin = true,
                Lots = lots
            };


        }

    }
}

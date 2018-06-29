using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MethodsDAL
    {
        private readonly DatabaseModel _ctx = new DatabaseModel();
        public void AddUser(User user)
        {
            _ctx.Users.Add(user);
            _ctx.SaveChanges();
        }
        public void ModifyUser(User user)
        {
            User user1 = _ctx.Users.First(u => u.ID == user.ID);
            user1.Login = user.Login;
            user1.Password = user.Password;
            user1.Name = user.Name;
            user1.PhoneNumber = user.PhoneNumber;
            _ctx.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            User user1 = _ctx.Users.SingleOrDefault(u => u.ID == user.ID);
            _ctx.Users.Remove(user1);
            _ctx.SaveChanges();
        }

        public List<User> GetUsers()
        {
            return _ctx.Users.ToList();
        }

        public List<Lot> GetLots()
        {
            return _ctx.Lots.ToList();
        }

        public void ReserveLot(int id)
        {
            Lot lot1 = _ctx.Lots.FirstOrDefault(l => l.ID == id);
            lot1.IsReserved = true;
            _ctx.SaveChanges();
        }

        public void AddLot(Lot lot)
        {
            _ctx.Lots.Add(lot);
            _ctx.SaveChanges();
        }

        public void LotEdit(Lot lot)
        {
            Lot newlot = _ctx.Lots.First(l => l.ID == lot.ID);
            newlot.Flour = lot.Flour;
            newlot.Address = _ctx.Addresses.FirstOrDefault(a => a.ID == lot.Address.ID) as Address;
            newlot.Apartment = lot.Apartment;
            newlot.Description = lot.Description;
            newlot.House = lot.House;
            newlot.Price = lot.Price;
            newlot.RoomsCount = lot.RoomsCount;
            newlot.IsReserved = lot.IsReserved;
            newlot.IsSold = lot.IsSold;
            newlot.Square = lot.Square;
            _ctx.SaveChanges();
        }

        public void DeleteLot(int id)
        {
            var lotremove = _ctx.Lots.FirstOrDefault(l => l.ID == id);
            _ctx.Lots.Remove(lotremove);
            _ctx.SaveChanges();
        }

        public Address CheckAdress(Address address)
        {
            var check = _ctx.Addresses.FirstOrDefault(a => a.Country == address.Country && a.City == address.City);
            return check;
        }
    }
}
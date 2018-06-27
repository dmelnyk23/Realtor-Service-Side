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
    }
}
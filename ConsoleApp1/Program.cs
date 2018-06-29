using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodsDAL methodsDAL = new MethodsDAL();
            methodsDAL.AddUser(new User {  Name="Gleb", IsAdmin = true, Login = "gleb123", Password = "123gleb", PhoneNumber = "0981789676"});
            User user = new User() { ID = 1 };
            methodsDAL.DeleteUser(user);
        }
    }
}

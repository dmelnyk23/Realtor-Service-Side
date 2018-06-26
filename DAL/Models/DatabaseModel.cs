using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DatabaseModel: DbContext
    {
   
        public DatabaseModel()
            : base("name=Realtor")
        {
            Database.SetInitializer<DatabaseModel>(new CustomInitializer<DatabaseModel>());
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Lot> Lots { get; set; }
        public virtual DbSet<Address> Addresses{ get; set; }
        public virtual DbSet<Photo> Photos{ get; set; }

    }
}

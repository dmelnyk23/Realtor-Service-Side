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
        }

    }
}

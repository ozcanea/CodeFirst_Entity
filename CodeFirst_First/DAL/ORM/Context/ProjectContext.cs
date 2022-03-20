using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CodeFirst_First.DAL.ORM.Entity;

namespace CodeFirst_First.DAL.Context
{
    internal class ProjectContext:DbContext

    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"server=.; database=mufredatecf; uid=sa; pwd=vkeww27";
        }

        //BaseEntity dbset olarak söylenmek zorunda değildir.
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

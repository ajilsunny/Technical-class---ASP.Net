using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Registration.Models
{
    public class Usercontext:DbContext
    {
        public Usercontext()
            :base("Mycon")
        {
            DropCreateDatabaseIfModelChanges<Usercontext> d = new DropCreateDatabaseIfModelChanges<Usercontext>();
            Database.SetInitializer<Usercontext>(d);

        }
        public DbSet<Userdemo> userdemos { get; set; }

        public System.Data.Entity.DbSet<Registration.Models.Student> Students { get; set; }
    }
}
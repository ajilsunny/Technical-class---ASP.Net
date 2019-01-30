using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;


namespace NewApp.Models
{
    public class UserContext:DbContext
    {
        public UserContext() 
            : base("Mycon")
        {
            DropCreateDatabaseIfModelChanges<UserContext> d = new DropCreateDatabaseIfModelChanges<UserContext>();
            Database.SetInitializer<UserContext>(d);
        }
        public DbSet<UserDemo> UserDemos { get; set; }
    }
}
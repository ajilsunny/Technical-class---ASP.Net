using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Studentdetails.Models
{
    public class Studentcontext:DbContext
    {
        public Studentcontext()
            :base("Myconn")
        {
            DropCreateDatabaseIfModelChanges<Studentcontext> d = new DropCreateDatabaseIfModelChanges<Studentcontext>();
            Database.SetInitializer<Studentcontext>(d);
        }
        public DbSet<StudentReg> studentRegs { get; set; }

        public System.Data.Entity.DbSet<Studentdetails.Models.Studentdept> Studentdepts { get; set; }

        public System.Data.Entity.DbSet<Studentdetails.Models.Studentinfo> Studentinfoes { get; set; }
    }
}
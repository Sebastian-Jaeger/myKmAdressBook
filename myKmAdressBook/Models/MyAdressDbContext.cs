using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace myKmAdressBook.Models
{
    public class MyAdressDbContext : DbContext 
    {
        public MyAdressDbContext(): base("Konica_Minolta")
        {

        }

        public DbSet<Adress> AdressList { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Vidly.Models
{
    public class VidlyContext : DbContext
    {
        public VidlyContext()
            :base("DefaultConnection")        
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}
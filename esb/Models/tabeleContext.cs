using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace esb.Models
{
    public class tabeleDbContext : DbContext
    {
        DbSet<Documents> Documents { get; set; }
        DbSet<Resources> Resources { get; set; }
        DbSet<Users> Users { get; set; }
    }
}
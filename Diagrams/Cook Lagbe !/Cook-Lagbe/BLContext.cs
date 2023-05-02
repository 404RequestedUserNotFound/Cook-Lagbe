using Cook_Lagbe.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cook_Lagbe
{
    public class BLContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Cook> Cooks { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
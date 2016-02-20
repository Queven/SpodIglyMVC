﻿using Microsoft.AspNet.Identity.EntityFramework;
using SpodIglyMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpodIglyMVC.DAL
{
    public class StoreContext: IdentityDbContext<ApplicationUser>
    {
        public StoreContext() : base("StoreContext")
        {
        }
        static StoreContext()
        {
            Database.SetInitializer(new StoreInitializer());
        }
        public static StoreContext Create()
        {
            return new StoreContext();
        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}

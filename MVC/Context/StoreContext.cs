using MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.Context
{
    public class StoreContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
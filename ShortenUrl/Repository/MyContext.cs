using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ShortenUrl.Models;

namespace ShortenUrl.Repository
{
    public class MyContext : DbContext
    {
        public MyContext() : base("DefaultConnection")
        {

        }
        public DbSet<Url> Urls { get; set; }
    }
}
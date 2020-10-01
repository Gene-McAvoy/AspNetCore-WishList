using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    public class ApplicationDbcontext : DbContext
    {
        
        public DbSet<Item> Items { get; set; }
        public ApplicationDbcontext(DbContextOptions options) : base(options)
        {
        
        }
    }
}

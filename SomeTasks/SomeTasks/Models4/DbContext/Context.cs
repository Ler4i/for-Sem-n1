using Microsoft.EntityFrameworkCore;
using SomeTasks.Models4.Interfaces.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models4.DbContext
{
    public class Context : Microsoft.EntityFrameworkCore.DbContext, IContext 
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Prices> Prices { get; set; }
        public DbSet<Unit> Units { get; set; }


    }
}

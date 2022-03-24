using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SomeTasks.Models4.Interfaces.DbContext
{
    interface IContext : IDisposable, IAsyncDisposable
    {
        DbSet<User> Users { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Products> Products { get; set; }
        DbSet<Prices> Prices { get; set; }
        DbSet<Unit> Units { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}

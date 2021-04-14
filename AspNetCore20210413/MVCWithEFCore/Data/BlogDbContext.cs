using Microsoft.EntityFrameworkCore;
using MVCWithEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWithEFCore.Data
{
    public class BlogDbContext : DbContext //-> using Microsoft.EntityFrameworkCore;
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) //DBContextOptions wird benötigt, damit wir in der Startup.cs auch dem EFCore Optionale Einstellungen übergeben können
            :base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
            
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScaffoldingSampleCRUD.Models;

namespace ScaffoldingSampleCRUD.Data
{
    public class ScaffoldingSampleCRUDContext : DbContext
    {
        public ScaffoldingSampleCRUDContext (DbContextOptions<ScaffoldingSampleCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<ScaffoldingSampleCRUD.Models.Blog> Blog { get; set; }
    }
}

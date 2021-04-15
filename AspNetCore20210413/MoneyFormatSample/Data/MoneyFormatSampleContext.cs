using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoneyFormatSample.Models;

namespace MoneyFormatSample.Data
{
    public class MoneyFormatSampleContext : DbContext
    {
        public MoneyFormatSampleContext (DbContextOptions<MoneyFormatSampleContext> options)
            : base(options)
        {
        }

        public DbSet<MoneyFormatSample.Models.Book> Book { get; set; }
    }
}

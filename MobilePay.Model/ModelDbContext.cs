using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePay.Model
{
    public class ModelDbContext : DbContext
    {
        public ModelDbContext(DbContextOptions<ModelDbContext> options) : base(options)
        {
        }

        public ModelDbContext()
        {
        }

        public DbSet<Pay> Pays { get; set; }
        public DbSet<PayLog> PayLogs { get; set; }
    }
}

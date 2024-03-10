using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcSample.Data
{
    public class MvcSampleContext : DbContext
    {
        public MvcSampleContext (DbContextOptions<MvcSampleContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; } = default!;
    }
}

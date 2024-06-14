using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication22;

namespace WebApplication22.Data
{
    public class WebApplication22Context : DbContext
    {
        public WebApplication22Context (DbContextOptions<WebApplication22Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication22.Person> Person { get; set; } = default!;
    }
}

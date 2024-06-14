using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication26.Models;

namespace WebApplication26.Data
{
    public class WebApplication26Context : DbContext
    {
        public WebApplication26Context (DbContextOptions<WebApplication26Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication26.Models.Recipe> Recipe { get; set; } = default!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication25.Models;

namespace WebApplication25.Data
{
    public class WebApplication25Context : DbContext
    {
        public WebApplication25Context (DbContextOptions<WebApplication25Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication25.Models.Student> Student { get; set; } = default!;
    }
}

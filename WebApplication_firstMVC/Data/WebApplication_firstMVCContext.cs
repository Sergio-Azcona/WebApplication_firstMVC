using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication_firstMVC.Models;

namespace WebApplication_firstMVC.Data
{
    public class WebApplication_firstMVCContext : DbContext
    {
        public WebApplication_firstMVCContext (DbContextOptions<WebApplication_firstMVCContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication_firstMVC.Models.Movie> Movie { get; set; } = default!;
    }
}

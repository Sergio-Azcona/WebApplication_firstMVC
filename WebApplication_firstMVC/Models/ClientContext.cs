using Microsoft.EntityFrameworkCore;
using WebApplication_firstMVC.Data;

namespace WebApplication_firstMVC.Models
{
    public class ClientContext : WebApplication_firstMVCContext
    {
        public ClientContext(DbContextOptions<WebApplication_firstMVCContext> options) : base(options) 
        { 
        }

        public DbSet<Client> Clients { get; set; }
    }
}

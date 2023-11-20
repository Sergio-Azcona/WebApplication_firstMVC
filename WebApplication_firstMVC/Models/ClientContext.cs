using Microsoft.EntityFrameworkCore;

namespace WebApplication_firstMVC.Models
{
    public class ClientContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        
        public ClientContext(DbContextOptions options) : base(options) 
        { 
        
        }

    }
}

using Microsoft.EntityFrameworkCore;
using practiespp.Models;

namespace practiespp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            :base(options) 
        {
            
        }
        public DbSet<Customer>Customers{ get; set; }
      
        
    }
    
}

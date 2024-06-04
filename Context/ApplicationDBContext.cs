using Microsoft.EntityFrameworkCore;
using WPS.Model;

namespace WPS.Context
{
    public class ApplicationDBContext : DbContext
    {
       public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        { 
        
        }

        public DbSet<Person> Person { get; set; }  
        public DbSet<Worker> Worker { get; set; }  
        public DbSet<Department> Department { get; set; }  
    }
}
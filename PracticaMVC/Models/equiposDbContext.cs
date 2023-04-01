using Microsoft.EntityFrameworkCore;

namespace PracticaMVC.Models
{
    public class equiposDbContext : DbContext
    {
       
            public equiposDbContext(DbContextOptions options) : base(options)
            {

            }


            public DbSet<Marcas> Marcas { get; set; }
    
    }
}

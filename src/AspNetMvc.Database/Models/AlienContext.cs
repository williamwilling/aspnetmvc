using System.Data.Entity;

namespace AspNetMvc.Database
{
    public class AlienContext : DbContext
    {
        public DbSet<Alien> Aliens { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using MVCDemoThing.Models;

namespace MVCDemoThing.Data
{
    public class PersonDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options) { }
    }
}

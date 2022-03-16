using Microsoft.EntityFrameworkCore;

namespace TerraformAPI
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> dbContext): base(dbContext)
        {

        }
        public DbSet<Person> Person { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

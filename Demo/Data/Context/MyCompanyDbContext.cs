using Demo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.Data.Context;

public class MyCompanyDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseSqlServer("Date Source=.;Initial Catalog=MyCompanyGroup3;Integrated Security=true");
        // optionsBuilder.UseSqlServer("Date Source=.;Initial Catalog=MyCompanyGroup3;UserId=sa;Password=123456");
        optionsBuilder.UseSqlServer("Server=.;Database=MyCompanyGroup3;Trusted_Connection=True;TrustServerCertificate=True;");
    }
    
    // DbContext class --> Create DbSet<Entity> --> Mapping for this entity to table in database
    // named with --> name of the DbSet property
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Project> Projects { get; set; }
}
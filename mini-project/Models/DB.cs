using Microsoft.EntityFrameworkCore;

namespace mini_project.Models;

#nullable disable warnings
public class DB(DbContextOptions options) : DbContext(options)
{
    // DbSet
    public DbSet<SampleEntity> SampleEntities { get; set; }
}

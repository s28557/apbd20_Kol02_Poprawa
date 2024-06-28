using Kol02.Models;
using Microsoft.EntityFrameworkCore;

namespace Kol02.Data;

public class DatabaseContext : DbContext
{
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Car> Cars { get; set; }
    public DbSet<CarRental> CarRentals { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<Model> Models { get; set; }
}
using Microsoft.EntityFrameworkCore;
using SampleMovies.Models;

namespace SampleMovies.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; }
}

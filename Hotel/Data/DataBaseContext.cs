using Microsoft.EntityFrameworkCore;

namespace Hotel.Data;

public class DataBaseContext : DbContext
{
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Reservation> Reservations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Specifying with database to use, a method that is available because
        // i imported nuget package for SQLite
        // The argument is the name of the database file "To do.db"  
        // Sqlite is just a single file, so it is easy to work with
        optionsBuilder.UseSqlite("Data Source = C:/Users/nagit/RiderProjects/Hotel/Hotel/Data/Database/Hotel.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuring each table with keys and constraints,
        modelBuilder.Entity<Room>().HasKey(r => r.Id);
        modelBuilder.Entity<Reservation>().HasKey(res => res.Id);
    }
}
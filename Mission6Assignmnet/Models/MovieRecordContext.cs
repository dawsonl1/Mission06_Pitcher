using Microsoft.EntityFrameworkCore;

namespace Mission6Assignmnet.Models;

public class MovieRecordContext : DbContext
{
    public MovieRecordContext(DbContextOptions<MovieRecordContext> options) : base(options) { } // Called automatically by ASP.NET; injects database settings and initializes the DbContext.
    
    public DbSet<MovieRecord> MovieRecords { get; set; } // Creates a table in the database - MovieRecords
}
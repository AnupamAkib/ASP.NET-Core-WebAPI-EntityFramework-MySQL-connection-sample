using TestingConnection.Models;
using Microsoft.EntityFrameworkCore;

namespace TestingConnection;

public class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options) : base(options)
    {
    }

    public DbSet<ErrorEntity> Errors { get; set; }
}
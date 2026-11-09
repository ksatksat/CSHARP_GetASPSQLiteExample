using Microsoft.EntityFrameworkCore;
using SimpleMessageApp.Models;

namespace SimpleMessageApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Message> Messages => Set<Message>();
}

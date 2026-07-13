using Microsoft.EntityFrameworkCore;

namespace FirstMinimalApi;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> User {get;set;}
}
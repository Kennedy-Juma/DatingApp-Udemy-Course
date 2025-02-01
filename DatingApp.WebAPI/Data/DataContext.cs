using DatingApp.WebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.WebAPI.Data
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<AppUser> Users { get; set; }
    }
}

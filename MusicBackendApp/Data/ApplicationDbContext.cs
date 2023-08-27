using Microsoft.EntityFrameworkCore;
using MusicBackendApp.Model;

namespace MusicBackendApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Song> songs { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { 

        }   
    }
}

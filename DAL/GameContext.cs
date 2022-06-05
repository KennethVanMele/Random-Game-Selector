using Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class GameContext : DbContext
    {
        public GameContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "Games.db");
        }

        public DbSet<Game> Games { get; set; } = default!;
        public DbSet<Platform> Platforms { get; set; } = default!;

        public string DbPath { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");
    }
}
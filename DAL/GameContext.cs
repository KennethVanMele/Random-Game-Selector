using Domain;
using System.Data.Entity;

namespace DAL
{
    public class GameContext : DbContext
    {
        public GameContext():base("GameDB") {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<GameContext>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<GameContext>());
            Database.SetInitializer(new CreateDatabaseIfNotExists<GameContext>());
        }

        public DbSet<Platform> Platformen { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
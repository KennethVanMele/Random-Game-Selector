using Domain;
using System.Collections;

namespace DAL
{
    public class GameRepo : IDisposable
    {
        private readonly GameContext gCont = new GameContext();

        public Game GetGame(int platformId, int gameId)
        {
            return gCont.Games.Single(game => game.Id == gameId && game.PlatformID == platformId);
        }

        public ArrayList GetGameId(int platformId)
        {
            ArrayList items = new ArrayList();
            items.AddRange(gCont.Games.Where(game => game.PlatformID == platformId).Select(g => new { g.Id }).ToList());
            return items;
        }

        public Game AddGame(Game game)
        {
            gCont.Database.EnsureCreated();
            gCont.Add(game);
            gCont.SaveChanges();
            return game;
        }

        public List<Game> GetGames()
        {
            return gCont.Games.OrderBy(g => g.Title).ToList();
        }

        public void RemoveGames(List<String> gamesToRemove)
        {
            foreach (string title in gamesToRemove)
            {
                //Get game to remove
                Game gtr = gCont.Games.Where(g => g.Title == title).First();
                gCont.Games.Remove(gtr);
                gCont.SaveChanges();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                gCont.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
using Domain;
using DAL;
using System;
using System.Collections.Generic;

namespace BL
{
    public class GameController
    {
        private static readonly GameRepo repoG = new GameRepo();
        private static readonly PlatformRepo repoP = new PlatformRepo();

        public string GameNaam()
        {
            var lijst = repoG.GetGameId(PlatformController.Platform);
            int lengte = lijst.Count;
            int i = RandIdGen.CalcId(lengte);
            var GameId = lijst[i-1].ToString();
            var start = GameId.IndexOf("=");
            var last = GameId.LastIndexOf("}");
            var span = last - start;
            GameId = GameId.Substring(start + 1, span - 1);
            return repoG.GetGame(PlatformController.Platform, int.Parse(GameId)).Title;
        }

        public void AddGame(string _Title, string _Platform)
        {
            var Platform = repoP.GetPlaformByName(_Platform).PlatformID;
            var g = new Game
            {
                Title = _Title,
                PlatformID = Platform
            };
            repoG.AddGame(g);
        }

        public List<Game> GetGames()
        {
            return repoG.GetGames();
        }

        public void RemoveGames(List<String> gamesToRemove)
        {
            repoG.RemoveGames(gamesToRemove);
        }
    }
}

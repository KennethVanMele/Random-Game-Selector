using DAL;
using Domain;

namespace BL
{
    public class PlatformController
    {
        private static readonly PlatformRepo repo = new();

        internal static int Platform { get; set; }

        public string PlatformName()
        {
            var all = repo.GetPlatforms();
            if (all.Count == 0)
                return "No platforms configured";

            var rnd = new Random();
            var platform = all[rnd.Next(all.Count)];
            Platform = platform.PlatformID;
            return platform.PlatformName;
        }

        public void AddPlatform(string platformname)
        {
            var p = new Platform
            {
                PlatformName = platformname
            };
            repo.AddPlatform(p);
        }

        public List<Platform> GetPlatform()
        {
            return repo.GetPlatforms();
        }
    }
}
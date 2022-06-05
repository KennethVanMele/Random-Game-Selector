using Domain;

namespace DAL
{
    public class PlatformRepo : IDisposable
    {
        private readonly GameContext gCont = new GameContext();

        public Platform GetPlatform(int platformId)
        {
            return gCont.Platforms.Single(platform => platform.PlatformID == platformId);
        }

        public Platform GetPlaformByName(string platformNaam)
        {
            return gCont.Platforms.Single(platform => platform.PlatformName == platformNaam);
        }

        public int GetNumOfPlatform()
        {
            var Platformen = gCont.Platforms.ToList();
            return Platformen.Count;
        }

        public List<Platform> GetPlatforms()
        {
            return gCont.Platforms.ToList();
        }

        public Platform AddPlatform(Platform platform)
        {
            gCont.Database.EnsureCreated();
            gCont.Add(platform);
            gCont.SaveChanges();
            return platform;
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
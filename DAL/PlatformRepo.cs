using Domain;
using System.Linq;
using System.Collections.Generic;
using System;

namespace DAL
{
    public class PlatformRepo : IDisposable
    {
        private readonly GameContext gCont = new GameContext();

        public Platform GetPlatform(int platformId)
        {
            return gCont.Platformen.Single(platform => platform.PlatformID == platformId);
        }

        public Platform GetPlaformByName(string platformNaam)
        {
            return gCont.Platformen.Single(platform => platform.PlatformName == platformNaam);
        }

        public int GetNumOfPlatform()
        {
            var Platformen = gCont.Platformen.ToList();
            return Platformen.Count;
        }

        public List<Platform> GetPlatformen() {
            return gCont.Platformen.ToList();
        }

        public Platform AddPlatform(Platform platform)
        {
            platform = gCont.Platformen.Add(platform);
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
using DAL;
using System;
using Domain;
using System.Collections.Generic;

namespace BL
{
    public class PlatformController
    {
        private static readonly PlatformRepo repo = new PlatformRepo();

        internal static int Platform { get; set; }

        public string PlatformNaam()
        {
            try
            {
                Platform = RandIdGen.CalcId(repo.GetNumOfPlatform());
                return repo.GetPlatform(Platform).PlatformName;
            }
            catch
            {
                var rnd = new Random();

                if (rnd.Next() % 2 == 0){ Platform++; }
                else { Platform--; }

                return repo.GetPlatform(Platform).PlatformName;
            }
        }

        public void AddPlatform(string platformnaam) {
            var p = new Platform
            {
                PlatformName = platformnaam
            };
            repo.AddPlatform(p);
        }

        public List<Platform> GetPlatform()
        {
            return repo.GetPlatformen();
        }
    }
}

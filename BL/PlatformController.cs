using DAL;
using Domain;

namespace BL
{
    public class PlatformController
    {
        private static readonly PlatformRepo repo = new PlatformRepo();

        internal static int Platform { get; set; }

        public string PlatformName()
        {
            try
            {
                Platform = RandIdGen.CalcId(repo.GetNumOfPlatform());
                return repo.GetPlatform(Platform).PlatformName;
            }
            catch
            {
                var rnd = new Random();

                if (rnd.Next() % 2 == 0) { Platform++; }
                else { Platform--; }

                return repo.GetPlatform(Platform).PlatformName;
            }
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
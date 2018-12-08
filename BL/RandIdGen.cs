using System;

namespace BL
{
    internal static class RandIdGen
    {
        public static int CalcId(int BovenGrens)
        {
            var rnd = new Random();
            return rnd.Next(1, BovenGrens + 1);
        }
    }
}

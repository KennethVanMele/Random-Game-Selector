namespace BL
{
    internal static class RandIdGen
    {
        public static int CalcId(int UpperLimmit)
        {
            var rnd = new Random();
            return rnd.Next(1, UpperLimmit + 1);
        }
    }
}
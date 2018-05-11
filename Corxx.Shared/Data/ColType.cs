namespace Corxx.Shared.Data
{
    public static class ColType
    {
        /// <summary>
        /// Represents VARCHAR(MAX)
        /// </summary>
        /// <returns></returns>
        public static string Varchar() => $"VARCHAR(MAX)";
        public static string Varchar(int size) => $"VARCHAR({ size })";
    }
}

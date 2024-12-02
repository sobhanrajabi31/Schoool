namespace School.DataAccess
{
    public enum Framework { EF, AdoNET, InMemory}
    public sealed class DbFramework
    {
        public static Framework Framework { get; set; }
    }
}

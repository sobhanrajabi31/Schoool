namespace School.DataAccess
{
    public sealed class AdoConnection
    {
        public static string ConnectionString { get { return "Data Source=.;Initial Catalog=SchoolDB;Integrated Security=True";} }
    }
}

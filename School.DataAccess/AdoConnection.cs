using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccess
{
    public sealed class AdoConnection
    {
        public static string ConnectionString { get { return "Data Source=.;Initial Catalog=SchoolDB;Integrated Security=True";} }
    }
}

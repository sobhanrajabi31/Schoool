using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccess
{
    public static class AdoSqlCommands
    {
        public static SqlConnection StartAdoCon()
        {
            SqlConnection con = new SqlConnection(AdoConnection.ConnectionString);
            con.Open();
            return con;
        }

        public static List<SqlParameter> ModelToSqlParams<T>(T model)
        {
            var param = new List<SqlParameter>();
            var type = model.GetType();

            foreach (var prop in type.GetProperties())
            {
                if (prop.Name != "ErrorMessage" && prop.Name != "IsValid")
                {
                    param.Add(new SqlParameter($"@{prop.Name}",
                        prop.GetValue(model)));
                }
            }
            return param;
        }

        public static int ExcNonQueryProc(string proc, params SqlParameter[] ps)
        {
            SqlCommand cmd = new SqlCommand();
            if (ps != null)
                foreach (var p in ps)
                    cmd.Parameters.Add(p);

            int result;
            using (cmd.Connection = StartAdoCon())
            {
                cmd.CommandText = proc;
                cmd.CommandType = CommandType.StoredProcedure;
                result = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            return result;
        }

        public static int ExcNonQuerySql(string query, params SqlParameter[] ps)
        {
            SqlCommand cmd = new SqlCommand();
            if (ps != null)
                foreach (var p in ps)
                    cmd.Parameters.Add(p);

            int result;
            using (cmd.Connection = StartAdoCon())
            {
                cmd.CommandText = query;
                result = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            return result;
        }

        public static DataTable TableProc(string proc, params SqlParameter[] ps)
        {
            SqlCommand cmd = new SqlCommand();
            if (ps != null)
                foreach (var p in ps)
                    cmd.Parameters.Add(p);

            cmd.Connection = StartAdoCon();
            cmd.CommandText = proc;
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dataTable = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, cmd.Connection);

            da.Fill(dataTable);

            cmd.Connection.Close();
            return dataTable;
        }

        public static DataTable TableSql(string query, params SqlParameter[] ps)
        {
            SqlCommand cmd = new SqlCommand();
            if (ps != null)
                foreach (var p in ps)
                    cmd.Parameters.Add(p);

            cmd.Connection = StartAdoCon();
            cmd.CommandText = query;

            DataTable dataTable = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, cmd.Connection);

            da.Fill(dataTable);

            cmd.Connection.Close();
            return dataTable;
        }
    }
}

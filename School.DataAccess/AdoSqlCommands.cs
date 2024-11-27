using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccess
{
    public class AdoSqlCommands
    {
        private SqlConnection StartAdoCon()
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

        protected int ExcNonQueryProc(string proc, params SqlParameter[] ps)
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

        protected int ExcNonQuerySql(string query, params SqlParameter[] ps)
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

        protected SqlDataReader ExcReaderProc(string proc, params SqlParameter[] ps)
        {
            SqlCommand cmd = new SqlCommand();
            if (ps != null)
                foreach (var p in ps)
                    cmd.Parameters.Add(p);

            cmd.Connection = StartAdoCon();
            cmd.CommandText = proc;
            cmd.CommandType = CommandType.StoredProcedure;
            var result = cmd.ExecuteReader();
            //cmd.Connection.Close();
            return result;
        }

        protected SqlDataReader ExcReaderSql(string query, params SqlParameter[] ps)
        {
            SqlCommand cmd = new SqlCommand();
            if (ps != null)
                foreach (var p in ps)
                    cmd.Parameters.Add(p);

            cmd.Connection = StartAdoCon();
            cmd.CommandText = query;
            var result = cmd.ExecuteReader();
            //cmd.Connection.Close();
            return result;
        }

        protected SqlDataReader ExcReaderFunc(string funcName, params SqlParameter[] ps)
        {
            SqlCommand cmd = new SqlCommand();
            string commandText = "select " + funcName + "(";
            if (ps != null)
            {
                foreach (var p in ps)
                {
                    cmd.Parameters.Add(p);
                    commandText += p.ParameterName + ",";
                }
            }

            cmd.Connection = StartAdoCon();
            commandText = commandText.Remove(commandText.Length - 1, 1);
            commandText += ")";
            cmd.CommandText = commandText;
            var result = cmd.ExecuteReader();
            //cmd.Connection.Close();
            return result;
        }
    }
}

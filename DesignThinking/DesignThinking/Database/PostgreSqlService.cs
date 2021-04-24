using DesignThinking.Base;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignThinking.Database
{
    public class PostgreSqlService : ISqlService
    {
        private string host = "Host = db-postgresql-fra1-20267-do-user-8952300-0.b.db.ondigitalocean.com";
        private string port = "Port = 25060";
        private string database = "Database = defaultdb";
        private string username = "Username = doadmin";
        private string password = "Password = sy60uuu8mm6geel1";
        private string ssl = "SSL Mode = Require; Trust Server Certificate = true;";

        private NpgsqlConnection con;
        private NpgsqlCommand cmd;
        public void Close()
        {
            if (con == null)
            {

            }
            else
                if (con.State == ConnectionState.Open)
                    con.Close();
        }

        public void Dispose()
        {
            Close();
        }
        public IDbConnection GetConnection()
        {
            string connectionString = $"{host}; {port}; {database}; {username}; {password}; {ssl}";

            con = new NpgsqlConnection(connectionString);
            cmd = new NpgsqlCommand(null, con);
            try
            {
                cmd.CommandTimeout = 0;
                cmd.Connection.Open();
                cmd.CommandTimeout = 0;
            }
            catch (Exception)
            {
            }
            while (cmd.Connection.State != ConnectionState.Open)
            {

            }
            return cmd.Connection;
        }
    }
}

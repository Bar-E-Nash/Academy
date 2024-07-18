using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Academy
{
    public static class DBcontext
    {
        public static DataTable MakeQuery(string queryStr, SqlParameter[] parameters)
        {
            DataTable output = new DataTable();

            using (SqlConnection conn = new SqlConnection(GetConnString()))
            using (SqlCommand cmd = new SqlCommand(queryStr, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                try
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(output);
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);

                }

            }
            return output;
        }
        private static string GetConnString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddUserSecrets<AdminForm>()
                .Build();

            string? connStr = config["conn_str"];
            if (connStr == null)
                throw new Exception("Cannot read conn string from secrets");
            return connStr;
        }
    }
}


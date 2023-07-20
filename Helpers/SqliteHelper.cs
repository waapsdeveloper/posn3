using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using POSN3.Helpers.ModelHelpers;
using System.Data.SqlClient;
using System.Data;

namespace POSN3.Helpers
{
    internal class SqliteHelper
    {
        private SqlConnection connection;

        public bool initialize()
        {
            UtilityHelper.consoleLog("sql initialized");
            return connect();
        }

        public async Task<SqlConnection> getConnectionAsync() => await newconnect();

        private async Task<SqlConnection> newconnect()
        {
            if (connection == null)
            {
                connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\WAAPS-52\\Desktop\\Shoaib\\Jozo\\pos-n3\\POSN3\\posn3lc.mdf;Integrated Security=True");
                await connection.OpenAsync(); // Open the connection asynchronously
            }

            return connection;
        }

        bool connect()
        {
            try
            {
                newconnect();

                Creater cr = new Creater(this);
                cr.initialize();

                Seeder sd = new Seeder(this);
                sd.initialize();

                UtilityHelper.consoleLog("database connection successful");
            }
            catch (Exception e)
            {
                UtilityHelper.consoleLog("error opening database connection " + e.Message);
                return false;
            }

            return true;
        }

        public async Task<int> execute(string sql, object[] param)
        {
            try
            {
                if (connection == null)
                {
                    await newconnect();
                }

                if (connection.State == ConnectionState.Closed)
                {
                    await newconnect();
                }

                UtilityHelper.consoleLog(sql);
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    var result = await command.ExecuteNonQueryAsync();
                    return result;
                }
            }
            catch (Exception e)
            {
                UtilityHelper.consoleLog(e.Message);
                return 0;
            }
        }

        public async Task<DataTable> executeData(string sql, Object[] param)
        {
            try
            {
                await newconnect(); // Ensure connection is open asynchronously

                UtilityHelper.consoleLog(sql);
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    var dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    await Task.Run(() => da.Fill(dt)); // Execute data query asynchronously
                    connection.Close();
                    return dt;
                }
            }
            catch (Exception e)
            {
                UtilityHelper.consoleLog(e.Message);
                return new DataTable();
            }
        }

        public async Task<SqlCommand> executeDataTable(string sql, Object[] param)
        {
            try
            {
                await newconnect(); // Ensure connection is open asynchronously

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    await command.ExecuteNonQueryAsync();
                    connection.Close();
                    return command;
                }
            }
            catch (Exception e)
            {
                UtilityHelper.consoleLog(e.Message);
                return null;
            }
        }
    }
}

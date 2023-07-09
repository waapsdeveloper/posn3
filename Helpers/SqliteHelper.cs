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

        bool connect()
        {

            try
            {

                connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\WAAPS-52\\Desktop\\Shoaib\\Jozo\\pos-n3\\POSN3\\posn3lc.mdf;Integrated Security=True");

                Creater cr = new Creater(this);
                cr.initialize();
                
                Seeder sd = new Seeder(this); 
                sd.initialize();

                UtilityHelper.consoleLog("database connection successful");
            } catch (Exception e)
            {
                UtilityHelper.consoleLog("error opening database connection " + e.Message);
                return false;
            }

            return true;
        }

        


        public int execute(string sql, Object[] param) {

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                
                UtilityHelper.consoleLog(sql);
                SqlCommand command = new SqlCommand(sql, connection);
                var result = command.ExecuteNonQuery();
                connection.Close();
                return result;
            } catch (Exception e)
            {
                UtilityHelper.consoleLog(e.Message);
                return 0;
            }
            


        }

        public DataTable executeData(string sql, Object[] param)
        {

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                UtilityHelper.consoleLog(sql);
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                connection.Close();
                return dt;
            }
            catch (Exception e)
            {
                UtilityHelper.consoleLog(e.Message);
                DataTable dt = new DataTable();
                return dt;
            }



        }


        public SqlCommand executeDataTable(string sql, Object[] param)
        {

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return command;
            }
            catch (Exception e)
            {
                UtilityHelper.consoleLog(e.Message);
                return null;
            }



        }




    }
}

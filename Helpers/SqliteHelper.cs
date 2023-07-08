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

        private SQLiteConnection connection = new SQLiteConnection("Data Source=posn3.db");

        public bool initialize()
        {
            UtilityHelper.consoleLog("sqlite initialized");
            return connect();
        }

        bool connect()
        {

            try
            {
                
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
                connection.Open();
                UtilityHelper.consoleLog(sql);
                SQLiteCommand command = new SQLiteCommand(sql, connection);
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
                connection.Open();
                UtilityHelper.consoleLog(sql);
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();
                SQLiteDataAdapter da = new SQLiteDataAdapter(command);
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


        public SQLiteCommand executeDataTable(string sql, Object[] param)
        {

            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(sql, connection);
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

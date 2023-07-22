using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace POSN3.Helpers.ModelHelpers
{
    internal class UserHelper
    {
        SqliteHelper sqliteHelper;
        public UserHelper(SqliteHelper sqliteHelper)
        {
            this.sqliteHelper = sqliteHelper;
        }

        public async Task<DataTable> all()
        {
            string sql = "Select * from Users";

            object[] values = { };
            DataTable dt = sqliteHelper.executeData(sql, values);
            UtilityHelper.consoleLog("Users table created successful");
            return dt;
        }

        public async Task<DataTable> emailPasswordCheck(string email, string password)
        {
            string sql = "Select TOP 1 * from Users where email = '" + email + "' and password = '" + password + "'";

            object[] values = { };
            DataTable dt = sqliteHelper.executeData(sql, values);
            UtilityHelper.consoleLog("Users table created successful");
            return dt;
        }

        public async void setActiveUser(int id)
        {
            string sql = "Update Users SET is_login = 0 where id != " + id;

            object[] values = { }; 
            var r = sqliteHelper.execute(sql, values);

            string sqla = "Update Users SET is_login = 1 where id = " + id;

            var f = sqliteHelper.execute(sqla, values);

        }



        public async Task<bool> insertAsync(string? name = null, string? email = null, string? password = null, int? role_id = null)
        {
            string sql = "INSERT INTO Users ";
            sql += "(";

            List<string> columns = new List<string>();
            List<string> values = new List<string>();

            if (!string.IsNullOrEmpty(name))
            {
                columns.Add("name");
                values.Add("'" + name + "'");
            }

            if (!string.IsNullOrEmpty(email))
            {
                columns.Add("email");
                values.Add("'" + email + "'");
            }

            if (!string.IsNullOrEmpty(password))
            {
                columns.Add("password");
                values.Add("'" + password + "'");
            }

            if (role_id.HasValue)
            {
                columns.Add("role_id");
                values.Add(role_id.ToString());
            }

            sql += string.Join(", ", columns);
            sql += ") VALUES (";
            sql += string.Join(", ", values);
            sql += ")";

            object[] sqlParameters = { };

            var result = sqliteHelper.execute(sql, sqlParameters);
            return result != 0;
        }


        public async Task<bool> updateAsync(int id, string name = null, string email = null, string password = null, int? role_id = null)
        {
            try
            {
                string sql = "UPDATE Users SET ";

                if (!string.IsNullOrEmpty(name))
                    sql += "name = '" + name + "', ";

                if (!string.IsNullOrEmpty(email))
                    sql += "email = '" + email + "', ";

                if (!string.IsNullOrEmpty(password))
                    sql += "password = '" + password + "', ";

                if (role_id.HasValue)
                    sql += "role_id = " + role_id.Value + ", ";

                var updated_at = DateTime.Now;
                sql += "updated_at = '" + updated_at + "' ";

                sql += "WHERE id = " + id;

                object[] values = { };

                var rowsAffected = sqliteHelper.execute(sql, values);
                UtilityHelper.consoleLog("User table updated successfully");
                return rowsAffected != 0;
            }
            catch (Exception ex)
            {
                UtilityHelper.consoleLog("User Update Error: " + ex.Message);
                return false;
            }
        }





        public async Task<bool> deleteAsync(int id)
        {


            try
            {

                string sql = "DELETE FROM Users ";

            sql += " WHERE ";
            sql += "id = " + id;
            object[] valuesa = { };

            var ra = sqliteHelper.execute(sql, valuesa);
            return ra == 0 ? false : true;
            }
            catch (Exception ex)
            {
                UtilityHelper.consoleLog("User Update Error: " + ex.Message);
                return false;
            }
        }

    }
}

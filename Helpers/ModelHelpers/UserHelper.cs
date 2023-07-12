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

        public DataTable all()
        {
            string sql = "Select * from Users";

            object[] values = { };
            DataTable dt = sqliteHelper.executeData(sql, values);
            UtilityHelper.consoleLog("Users table created successful");
            return dt;
        }

        //public DataTable get(Object[] param)
        //{
        //    string sql = "Select * from Users";

        //object[] values = { };
        //var r = sqliteHelper.executeDataTable(sql, values);
        //UtilityHelper.consoleLog("Users table created successful");
        //SQLiteDataAdapter da = new SQLiteDataAdapter(r);
        //DataTable dt = new DataTable();
        //da.Fill(dt);
        //return dt;
        //}

        public bool insert(string name, string email, string password, int role_id)
        {
            string sqla = "INSERT INTO Users ";
            sqla += "(";
            sqla += "name, ";
            sqla += "email, ";
            sqla += "password, ";
            sqla += "role_id ";
            sqla += ") ";
            sqla += "VALUES ('"+name+"','"+email+"','"+password+"', " + role_id + ")";

            object[] valuesa = { };

            var ra = sqliteHelper.execute(sqla, valuesa);
            return ra == 0 ? false : true;
        }

        public bool update(int id, string name, string email, string password, int role_id)
        {
            try
            {
                string sqla = "UPDATE Users SET ";
                sqla += "name = '" + name + "', ";
                sqla += "email = '" + email + "', ";
                sqla += "password = '" + password + "', ";
                sqla += "role_id = " + role_id + ", ";

                var updated_at = DateTime.Now;
                sqla += "updated_at = '" +  updated_at + "' ";
                sqla += "WHERE id = " + id;

                object[] valuesa = { };

                var ra = sqliteHelper.execute(sqla, valuesa);
                UtilityHelper.consoleLog("Users table created successful");
                return ra == 0 ? false : true;

            } catch (Exception ex)
            {
                UtilityHelper.consoleLog("User Update Error:" + ex.Message);
                return false;
            }

        }

        public bool delete(Object[] param)
        {
            string sqla = "INSERT INTO Users ";
            sqla += "(";
            sqla += "`name`, ";
            sqla += "`email`, ";
            sqla += "`password` ";
            sqla += ") ";
            sqla += "VALUES ('ANAS','ANAS.AHMED142@GMAIL.COM','123456789')";

            object[] valuesa = { };

            var ra = sqliteHelper.execute(sqla, valuesa);
            return ra == 0 ? false : true;

        }

    }
}

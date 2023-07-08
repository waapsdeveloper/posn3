using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

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
            var r = sqliteHelper.executeDataTable(sql, values);
            UtilityHelper.consoleLog("Users table created successful");
            SQLiteDataAdapter da = new SQLiteDataAdapter(r);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable get(Object[] param)
        {
            string sql = "Select * from Users";

            object[] values = { };
            var r = sqliteHelper.executeDataTable(sql, values);
            UtilityHelper.consoleLog("Users table created successful");
            SQLiteDataAdapter da = new SQLiteDataAdapter(r);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool insert(string name, string email, string password)
        {
            string sqla = "INSERT INTO Users ";
            sqla += "(";
            sqla += "`name`, ";
            sqla += "`email`, ";
            sqla += "`password` ";
            sqla += ") ";

            

            sqla += "VALUES ('"+name+"','"+email+"','"+password+"')";

            object[] valuesa = { };

            var ra = sqliteHelper.execute(sqla, valuesa);
            return ra == 0 ? false : true;

        }

        public bool update(Object[] param)
        {
            string sqla = "UPDATE Users ";
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

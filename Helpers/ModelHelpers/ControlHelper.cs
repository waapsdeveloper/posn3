using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSN3.Helpers.ModelHelpers
{
    internal class ControlHelper
    {
        SqliteHelper sqliteHelper;
        public ControlHelper(SqliteHelper sqliteHelper)
        {
            this.sqliteHelper = sqliteHelper;
        }

        public async Task<bool> authenticate(string email, string password)
        {
            UserHelper uh = new UserHelper(sqliteHelper);
            DataTable dt = await uh.emailPasswordCheck(email, password);

            if (dt.Rows.Count > 0)
            {
                DataRow firstRow = dt.Rows[0];
                int id = Convert.ToInt32(firstRow["id"]);
                setAuthUserActive(id);
            }

            return dt.Rows.Count > 0 ? true : false;
        }

        public void setAuthUserActive(int id)
        {
            UserHelper uh = new UserHelper(sqliteHelper);
            uh.setActiveUser(id);
        }
    }
}

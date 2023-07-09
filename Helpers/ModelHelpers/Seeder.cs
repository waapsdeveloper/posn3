using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSN3.Helpers.ModelHelpers
{
    internal class Seeder
    {
        SqliteHelper sqliteHelper;
        public Seeder(SqliteHelper sqliteHelper)
        {
            this.sqliteHelper = sqliteHelper;
        }
        public void initialize() {


            seedRoles();
            seedSuperUser();

        }

        void seedRoles()
        {
            UtilityHelper.consoleLog("start seeding for roles");

            string[] roles = { "super_admin", "admin", "account_holder", "user" };
            RoleHelper roleHelper = new RoleHelper(sqliteHelper);

            for (var i = 0; i < roles.Length; i++)
            {
                string a = roles[i];
                roleHelper.insert(a);
            }

        }


        void seedSuperUser()
        {
            // check if super admin settings done? 

            UtilityHelper.consoleLog("start seeding for super admin");

            RoleHelper roleHelper = new RoleHelper(sqliteHelper);

            // get role id of super user 
            DataTable dt = roleHelper.getByRoleName("super_admin");
            var row = dt.AsEnumerable().First();

            var role_id = row.Field<int>("id");

            // create a super admin user in database

            UserHelper userHelper = new UserHelper(sqliteHelper);
            userHelper.insert("super admin", "superadmin@email.com", "admin123$", role_id);



        }





    }


}

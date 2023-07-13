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
            seedCities();
            seedUnitMeasures();
            seedSuperUser();

        }

        void seedRoles()
        {
            UtilityHelper.consoleLog("start seeding for roles");

            string[] list = { "super_admin", "admin", "account_holder", "user" };
            RoleHelper helper = new RoleHelper(sqliteHelper);

            for (var i = 0; i < list.Length; i++)
            {
                string a = list[i];
                helper.insert(a);
            }

        }

        void seedCities()
        {
            UtilityHelper.consoleLog("start seeding for roles");

            string[] list = {
                "Berlin",
                "Hamburg",
                "Munich",
                "Cologne",
                "Frankfurt",
                "Stuttgart",
                "Dusseldorf",
                "Dortmund",
                "Essen",
                "Leipzig",
                "Bremen",
                "Dresden",
                "Hanover",
                "Nuremberg",
                "Duisburg"
            };
            CityHelper helper = new CityHelper(sqliteHelper);

            for (var i = 0; i < list.Length; i++)
            {
                string a = list[i];
                helper.insert(a);
            }

        }

        void seedUnitMeasures()
        {
            UtilityHelper.consoleLog("start seeding for roles");

            string[] list = { "inches", "centimeters", "feet", "meters" };
            UnitMeasureHelper helper = new UnitMeasureHelper(sqliteHelper);

            for (var i = 0; i < list.Length; i++)
            {
                string a = list[i];
                helper.insert(a);
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

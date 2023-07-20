using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using POSN3.Helpers;
using POSN3.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace POSN3
{
    public partial class Form1 : Form
    {
        public int step = 1;
        public Form1()
        {
            InitializeComponent();
            hideAllPanels();

            sidebar.Visible = false;
            UserControlViewInPanel.Visible = true;
            //loginSuccessful();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void hideAllPanels()
        {

            UserViewInPanel.Visible = false;
            RoleViewInPanel.Visible = false;
            TaxListViewInPanel.Visible = false;
            AccountListViewInPanel.Visible = false;
            AccountingViewInPanel.Visible = false;
            PartnerListViewInPanel.Visible = false;
            GroupsViewInPanel.Visible = false;
            ProductsViewInPanel.Visible = false;
            WarehouseListViewInPanel.Visible = false;
            InvoiceListViewInPanel.Visible = false;
            EmployeeListViewInPanel.Visible = false;
            MessageListViewInPanel.Visible = false;
            UserControlViewInPanel.Visible = false;
        }

        public void loginSuccessful()
        {
            sidebar.Visible = true;
            UserControlViewInPanel.Visible = false;
            hideAllPanels();
            showPanelBaseOnStep("login");

        }

        void showPanelBaseOnStep(string step)
        {
            hideAllPanels();
            switch (step)
            {
                case "login":
                    UserViewInPanel.Visible = true;
                    break;
                case "roles":
                    RoleViewInPanel.Visible = true;
                    break;
                case "taxlist":
                    TaxListViewInPanel.Visible = true;
                    break;
                case "accountlist":
                    AccountListViewInPanel.Visible = true;
                    break;
                case "accounting":
                    AccountingViewInPanel.Visible = true;
                    break;
                case "partner_list":
                    PartnerListViewInPanel.Visible = true;
                    break;
                case "groups":
                    GroupsViewInPanel.Visible = true;
                    break;
                case "products":
                    ProductsViewInPanel.Visible = true;
                    break;
                case "warehouse":
                    WarehouseListViewInPanel.Visible = true;
                    break;
                case "invoice_list":
                    InvoiceListViewInPanel.Visible = true;
                    break;
                case "employee_list":
                    EmployeeListViewInPanel.Visible = true;
                    break;
                case "messages":
                    MessageListViewInPanel.Visible = true;
                    break;
                case "clogin":
                    UserControlViewInPanel.Visible = true;
                    break;








            }
        }

        private void shutdown_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void sidebarusers_Click(object sender, EventArgs e)
        {
            UtilityHelper.consoleLog("point1");
            showPanelBaseOnStep("login");

        }

        private void sidebarroles_Click(object sender, EventArgs e)
        {
            UtilityHelper.consoleLog("point2");
            showPanelBaseOnStep("roles");
        }

        private void sidebartaxlist_Click(object sender, EventArgs e)
        {
            UtilityHelper.consoleLog("point3");
            showPanelBaseOnStep("taxlist");
        }



        private void sidebaracountlist_Click(object sender, EventArgs e)
        {
            UtilityHelper.consoleLog("point4");
            showPanelBaseOnStep("accountlist");
        }

        private void sidebaraccounting_Click(object sender, EventArgs e)
        {
            UtilityHelper.consoleLog("point5");
            showPanelBaseOnStep("accounting");
        }

        private void sidebarpartnerlist_Click(object sender, EventArgs e)
        {
            UtilityHelper.consoleLog("point6");
            showPanelBaseOnStep("partner_list");
        }

        private void sidebargroups_Click(object sender, EventArgs e)
        {
            UtilityHelper.consoleLog("point7");
            showPanelBaseOnStep("groups");
        }

        private void sidebarproducts_Click(object sender, EventArgs e)
        {
            UtilityHelper.consoleLog("point8");
            showPanelBaseOnStep("products");
        }

        private void sidebarwarehouse_Click(object sender, EventArgs e)
        {
            UtilityHelper.consoleLog("point9");
            showPanelBaseOnStep("warehouse");
        }

        private void sidebarinvoicelist_Click(object sender, EventArgs e)
        {
            UtilityHelper.consoleLog("point10");
            showPanelBaseOnStep("invoice_list");
        }

        private void sidebaremployeelist_Click(object sender, EventArgs e)
        {
            UtilityHelper.consoleLog("point11");
            showPanelBaseOnStep("employee_list");
        }

        private void sidebarmessages_Click(object sender, EventArgs e)
        {
            UtilityHelper.consoleLog("point12");
            showPanelBaseOnStep("messages");
        }

        private void Login_Click(object sender, EventArgs e)
        {
            UtilityHelper.consoleLog("point13");
            showPanelBaseOnStep("clogin");
        }
    }
}
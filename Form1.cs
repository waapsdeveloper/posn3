using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using POSN3.Helpers;
using POSN3.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static MaterialSkin.Controls.MaterialCheckedListBox;

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
            LogListViewInPanel.Visible = false;
            PaymentListViewInPanel.Visible = false;
            ProductsListViewInPanel.Visible = false;
            CityListViewInPanel.Visible = false;
            UomListViewInPanel.Visible = false;
            ItemListViewInPanel.Visible = false;
            HeaderListViewInPanel.Visible = false;
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
                case "logs":
                    LogListViewInPanel.Visible = true;
                    break;
                case "payments":
                    PaymentListViewInPanel.Visible = true;
                    break;
                case "products_list":
                    ProductsListViewInPanel.Visible = true;
                    break;
                case "city_list":
                    CityListViewInPanel.Visible = true;
                    break;
                case "uom_list":
                    UomListViewInPanel.Visible = true;
                    break;
                case "item_list":
                    ItemListViewInPanel.Visible = true;
                    break;
                case "header_list":
                    HeaderListViewInPanel.Visible = true;
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

        private void UserViewInPanel_Load(object sender, EventArgs e)
        {

        }

        private void sidebarlogs_Click(object sender, EventArgs e)
        {
            UtilityHelper.consoleLog("point14");
            showPanelBaseOnStep("logs");
        }

        private void sidebarpayments_Click(object sender, EventArgs e)
        {
            UtilityHelper.consoleLog("point15");
            showPanelBaseOnStep("payments");
        }

        private void sidebarproductlist_Click(object sender, EventArgs e)
        {
            UtilityHelper.consoleLog("point16");
            showPanelBaseOnStep("products_list");
        }

        private void sidebarcitylist_Click(object sender, EventArgs e)
        {
            UtilityHelper.consoleLog("point17");
            showPanelBaseOnStep("city_list");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sidebarupmlist_Click(object sender, EventArgs e)
        {
            UtilityHelper.consoleLog("point18");
            showPanelBaseOnStep("uom_list");
        }

        private void sidebaritemlist_Click(object sender, EventArgs e)
        {
            UtilityHelper.consoleLog("point18");
            showPanelBaseOnStep("item_list");
        }

        private void sidebarheader_Click(object sender, EventArgs e)
        {
            UtilityHelper.consoleLog("point18");
            showPanelBaseOnStep("header_list");
        }
    }
}
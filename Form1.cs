using System.Data;
using System.Diagnostics;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void hideAllPanels()
        {

            UserViewInPanel.Visible = false;
            RoleViewInPanel.Visible = false;
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

                    break;
            }
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

        private void shutdown_Click(object sender, EventArgs e)
        {

        }

        
    }
}
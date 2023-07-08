using System.Data;
using POSN3.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace POSN3
{
    public partial class Form1 : Form
    {
        public int step = 1;
        public Form1()
        {
            InitializeComponent();
            showPanelBaseOnStep(1);

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

        void showPanelBaseOnStep(int step)
        {
            string[] panels = { "login", "dashboard" };
            switch (step)
            {
                case 1:
                    topheading.Text = "Login";
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }
        }

        // shutdown button
        private void shutdownClick(object sender, System.EventArgs e)
        {

        }

        private void newrecordClick(object sender, EventArgs e)
        {

        }

        private void editrecordClick(object sender, EventArgs e)
        {

        }

        private void deleterecordClick(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dashboardbutton_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
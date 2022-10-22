using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace log_in
{
    public partial class Principal_Home : Form
    {
        public Principal_Home()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl user)
        {
            user.Dock = DockStyle.Right;
            guna2GradientPanel2.Controls.Clear();
            guna2GradientPanel2.Controls.Add(user);
            user.BringToFront();

        }
        private void approveRemoval_Click(object sender, EventArgs e)
        {

        }

        private void ViewReports_Click(object sender, EventArgs e)
        {
            //var viewR = new Form2();
            //viewR.Show();
            //var hideF1 = new Form1();
            //hideF1.Close();
            Principal_ViewReports v = new Principal_ViewReports();
            addUserControl(v);
        }

        private void checkPerf_Click(object sender, EventArgs e)
        {
            //var viewR = new performance();
            //viewR.Show();
            //var hideF1 = new Form1();
            //hideF1.Close();

            Principal_Performance v = new Principal_Performance();
            addUserControl(v);
        }

        private void viewDetails_Click(object sender, EventArgs e)
        {
            //var viewR = new personalDetails();
            //viewR.Show();
            //var hideF1 = new Form1();
            //hideF1.Close();

            Principal_Details v = new Principal_Details();
            addUserControl(v);
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {

        }
    }
}

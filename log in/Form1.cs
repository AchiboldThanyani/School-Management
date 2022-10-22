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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboDropDown1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string cb = comboBox1.SelectedItem.ToString();
            if(cb == "Principal")
            {
                this.Hide();
                Principal_Home adminHome = new Principal_Home();
                adminHome.Show();
            }
            else if(cb == "Admin")
            {
                this.Hide();
                Form2 adminHome = new Form2();
                adminHome.Show();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

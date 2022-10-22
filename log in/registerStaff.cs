using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace log_in
{
    public partial class registerStaff : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = C:\Users\thany\Music\log in\log in\Database1.mdf;Integrated Security=True");
        public registerStaff()
        {
            InitializeComponent();
        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Staff values('" + int.Parse(txtStaff1.Text) + "', '" + txtStaff2.Text + "','" + txtStaff3.Text + "','" + txtStaff4.Text + "','" + txtStaff5.Text + "','" + comboStaff1.SelectedItem.ToString() + "','" + comboStaff2.SelectedItem.ToString() + "','" + comboStaff3.SelectedItem.ToString() + "','" + comboStaff4.SelectedItem.ToString() + "')", connection);

            connection.Open();
            cmd.ExecuteNonQuery();

            connection.Close();
            displayData();
            MessageBox.Show("Staff inserted successfully");
        }
        public void displayData()
        {
            SqlCommand cmd = new SqlCommand("select* from Staff", connection);

            connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;

            connection.Close();
        }

        private void registerStaff_Load(object sender, EventArgs e)
        {
            displayData();
        }
    }
}

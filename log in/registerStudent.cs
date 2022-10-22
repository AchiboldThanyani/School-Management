using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace log_in
{
    public partial class registerStudent : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = C:\Users\thany\Music\log in\log in\Database1.mdf;Integrated Security=True");
        public registerStudent()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Student values('" + int.Parse(guna2TextBox1.Text) + "', '" + guna2TextBox4.Text + "','" + guna2TextBox3.Text + "','" + guna2TextBox6.Text + "','" + guna2TextBox5.Text + "','" + comboBox8.SelectedItem.ToString() + "','" + comboBox3.SelectedItem.ToString() + "','" + comboBox5.SelectedItem.ToString() + "','" + comboBox4.SelectedItem.ToString() + "','" + comboBox2.SelectedItem.ToString() + "','" + comboBox1.SelectedItem.ToString() + "','" + comboBox6.SelectedItem.ToString() + "','" + comboBox7.SelectedItem.ToString() + "')", connection);

            connection.Open();
            cmd.ExecuteNonQuery();
            
            connection.Close();
            displayData();
            MessageBox.Show("Student inserted successfully");
        }
        public void displayData()
        {
            SqlCommand cmd = new SqlCommand("select* from Student", connection);

            connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            connection.Close();
        }

        private void registerStudent_Load(object sender, EventArgs e)
        {
            displayData();
        }
    }
}

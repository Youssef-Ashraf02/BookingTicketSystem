using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tickium
{
    public partial class adminform : Form
    {
        public adminform()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            admin adm = new();
            adm = adm.deleteUser(email.Text);
            getdata();
        }

        private void adminform_Load(object sender, EventArgs e)
        {
            getdata();
        }
        private void getdata()
        {
            SqlConnection connection = new SqlConnection("Data Source=youssef;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from registrationtable", connection);
            DataTable dt = new DataTable();
            connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            connection.Close();
            dataGridView1.DataSource = dt;
        }

        private void create_Click(object sender, EventArgs e)
        {
            admin adm = new();
            adm = adm.Create(firstname.Text, lastname.Text, gender.Text, email.Text, password.Text);
            getdata();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void read_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            login frm = new login();
            frm.Show();
        }
    }
}

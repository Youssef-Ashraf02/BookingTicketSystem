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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tickium
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
            gender.Items.Add("Male");
            gender.Items.Add("Female");
        }
        SqlConnection connection = new SqlConnection("Data Source=youssef;Integrated Security=True");
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstname.Text != "" && lastname.Text != "" && gender.Text != "" && email.Text != "" && password.Text != "" && securitylevel.Text == "")
                {
                    int v = Check(email.Text);
                    if (v != 1)
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("insert into [dbo].[registrationtable] values(@firstname,@lastname,@gender,@email,@password,@securitylevel)", connection);
                        cmd.Parameters.AddWithValue("@firstname", firstname.Text);
                        cmd.Parameters.AddWithValue("@lastname", lastname.Text);
                        cmd.Parameters.AddWithValue("@gender", gender.Text);
                        cmd.Parameters.AddWithValue("@email", email.Text);
                        cmd.Parameters.AddWithValue("@password", password.Text);
                        cmd.Parameters.AddWithValue("@securitylevel", securitylevel.Text);


                        cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("registration done");
                        firstname.Text = "";
                        lastname.Text = "";
                        gender.Text = "";
                        email.Text = "";
                        password.Text = "";
                        securitylevel.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("already registered");
                    }
                }
                else
                {
                    MessageBox.Show("fill the data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int Check(string email)
        {

            connection.Open();
            string query = "SELECT COUNT(*) FROM [dbo].[registrationtable] where email='" + email + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;



        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            login frm = new login();
            frm.Show();
        }
    }
}

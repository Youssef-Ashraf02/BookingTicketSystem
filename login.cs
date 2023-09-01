using System.Data.SqlClient;
namespace tickium
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=youssef;Integrated Security=True");
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text != "" && txtuserpass.Text != "")
            {
                user p = new();
                p = p.loginCheck(txtusername.Text, txtuserpass.Text);
                if (p != null)
                {
                    if (p is admin)
                    {
                        MessageBox.Show("welcome admin!");
                        txtusername.Text = "";
                        txtuserpass.Text = "";
                        new adminform().Show();
                        this.Hide();
                    }
                    else if (p is user)
                    {
                        MessageBox.Show("welcome!");
                        txtusername.Text = "";
                        txtuserpass.Text = "";
                        new matches().Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("the name or password is incorrect");
                        txtusername.Clear();
                        txtuserpass.Clear();
                        txtusername.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
            else
            {
                MessageBox.Show("error username or password");
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new signup().Show();
            this.Hide();
        }

        private void txtuserpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtuserpass.UseSystemPasswordChar = true;
            }
            else
            {
                txtuserpass.UseSystemPasswordChar = false;
            }
        }
    }
}
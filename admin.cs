using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Data;

namespace tickium
{
    public class admin : user
    {
        SqlConnection connection = new SqlConnection("Data Source=youssef;Integrated Security=True");
        public admin()
        {

        }
        public admin(int id, string firstname, string lastname, string gender, string email, string password,int securitylevel) : base(id, firstname, lastname, gender, email, password,securitylevel)
        {

        }

        public admin? Create(string firstname, string lastname, string gender, string email, string password)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=youssef;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand("insert into [dbo].[registrationtable] values(@firstname,@lastname,@gender,@email,@password,@securitylevel)", connection);
                command.Parameters.AddWithValue("@firstname", firstname);
                command.Parameters.AddWithValue("@lastname", lastname);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@securitylevel", securitylevel);
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("succefuly created new data");
            }
            return null;
        }
        public admin? deleteUser(string email)
        {

            SqlConnection con = new SqlConnection("Data Source=youssef;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete [dbo].[registrationtable] where  email=@email", con);

            cmd.Parameters.AddWithValue("@email", email);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("succefuly deleted the account");
            return null;
        }
    }
}

       
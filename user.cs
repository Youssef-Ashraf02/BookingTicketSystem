using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tickium
{
    public class user : person
    {
        public int securitylevel;
        public user()
        {

        }
        public user(int id, string firstname, string lastname, string gender, string email, string password, int securitylevel) : base(id, firstname, lastname, gender, email, password)
        {
            this.securitylevel = securitylevel;
        }
        SqlConnection connection = new SqlConnection("Data Source=youssef;Integrated Security=True");

        public string Lastname { get; private set; }

        public user? loginCheck(string email, string password)
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select * from [dbo].[registrationtable] where email = @email and password = @password", connection);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    this.Id = Convert.ToInt32(dr.GetValue(0));
                    this.FirstName = dr.GetValue(1) + "";
                    this.Lastname = dr.GetValue(2) + "";
                    this.Gender = dr.GetValue(3) + "";
                    this.Email = dr.GetValue(4) + "";
                    this.Password = dr.GetValue(5) + "";
                    this.securitylevel = Convert.ToInt32(dr.GetValue(6));
                    connection.Close();
                    //MessageBox.Show(securitylevel+"");
                    if (this.securitylevel == 0)
                    {
                        return new user(Id, FirstName, Lastname, Gender, email, password, securitylevel);
                    }
                    else
                    {
                        return new admin(Id, FirstName, Lastname, Gender, email, password, securitylevel);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
            }

        }
}

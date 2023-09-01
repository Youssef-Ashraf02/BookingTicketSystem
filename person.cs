using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tickium
{
    public class person
    {
        private int id;
        private string firstname;
        private string lastname;
        private string gender;
        private string email;
        private string password;

        public int Id
        { 
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        { get { return firstname; }
          set { firstname = value; } 
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public person()
        {

        }
        public person(int id,string firstname,string lastname,string gender,string email,string password)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.email = email;
            this.password = password;
        }

    }
}

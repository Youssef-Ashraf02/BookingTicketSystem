using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tickium
{
    public class ticket 
    {
        public int ticket_num;

        public int Ticket_num
        {
            get { return ticket_num; }
            set { value=ticket_num; }
        }
        public ticket() { }
        public ticket(int ticket_num)
        {
            this.ticket_num = ticket_num;
        }

        public override string ToString()
        {
            return " " + ticket_num;
        }

    }
}

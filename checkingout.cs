using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tickium
{
    public class checkingout
    {
        public string customtext = "0";
        public string pric = "0";

        public string Customtext
        {
            get { return customtext; }
            set { customtext = value; }
        }
        public string Pric
        {
            get { return pric; }
            set { pric = value; }
        }

        public int calculate()
        {
            int result = (int.Parse(Customtext)) * (int.Parse(pric));
            return result;
        }
    }
}
